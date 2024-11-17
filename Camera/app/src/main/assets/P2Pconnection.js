const servers = {
    iceServers: [
        {
            urls: [
                'stun:stun.l.google.com:19302',
                //                'stun:stun1.l.google.com:19302',
                //                'stun:stun2.l.google.com:19302'
            ],
        },
    ],
    iceCandidatePoolSize: 10,
};

const peerConnections = {};
const pendingIceCandidates = {}
const addedIceCandidate = {}

let mediaStream;

const camera = new RTCPeerConnection(servers);
const soundFromSender = document.getElementById("sound-from-sender");

navigator.mediaDevices.getUserMedia({ video: { facingMode: "environment", width: { ideal: 1920 }, height: { ideal: 1080 }, frameRate: { ideal: 30 } }, audio: true })
    .then(stream => {
        mediaStream = stream;
        document.getElementById('local-video-stream').srcObject = stream;
    });

// function call from Java
function handlerOfferFromSenders(offer, userName) {
    const peerConnection = new RTCPeerConnection(servers);
    peerConnections[userName] = peerConnection;
    if (!pendingIceCandidates[userName])
        pendingIceCandidates[userName] = [];

    mediaStream.getTracks().forEach(track => peerConnection.addTrack(track, mediaStream));
    peerConnection.onicecandidate = (ev) => {
        if (ev.candidate) {
            // Send ICE Candidate to Android
            Android.receiveIceCandidate(JSON.stringify(ev.candidate), userName);
        }
    }

    peerConnection.ontrack = ev => {
        soundFromSender.srcObject = ev.streams[0];
    }

    peerConnection.oniceconnectionstatechange = () => {
        console.log(peerConnection.iceConnectionState);
        if (peerConnection.iceConnectionState === "disconnected") {
            peerConnection.close();
            peerConnections[userName] = undefined;
            pendingIceCandidates[userName] = undefined;
            // Send request disconnect to Android
            Android.disconnect(userName);
        }
    };

    setOfferFromSender(offer, userName)
}

function setOfferFromSender(offer, userName) {
    peerConnections[userName].setRemoteDescription(offer)
        .then(v => {
            console.log("Set offer success");
            createAnswer(userName);
        })
        .catch(err => console.log("Error: " + err))
}

function createAnswer(userName) {
    peerConnections[userName].createAnswer()
        .then(answer => {
            console.log("Create answer success");
            // Set answer created
            peerConnections[userName].setLocalDescription(answer)
                .then(v => {
                    console.log("Set answer success");
                    // Send answer to Android
                    Android.receiveAnswer(JSON.stringify(peerConnections[userName].localDescription), userName);
                })
                .catch(err => {
                    console.log("Error: " + err);
                })
        })
        .catch(err => console.log("Error: " + err))
}

// function call from Java
function setIceCandidateFromSender(userName) {

    // pendingIceCandidates[userName].forEach(candidate => {
    //     const candidateKey = JSON.stringify

    //     // If not have iceCandidate
    //     if (!addedIceCandidate[userName].has(candidateKey)) {
    //         peerConnections[userName].addIceCandidate(candidate)
    //             .then(() => {
    //                 console.log("Added ICE Candidate:", candidate);
    //                 addedIceCandidate[userName].add(candidateKey); // Lưu ICE Candidate đã thêm
    //             })
    //             .catch(err => console.error("Error adding ICE Candidate:", err));
    //     }
    //     else
    //         console.log("Duplicate ICE Candidate skipped: " +  candidate);
    // });
    console.log(pendingIceCandidates[userName]);
    pendingIceCandidates[userName].forEach(candidate => peerConnections[userName].addIceCandidate(candidate))
    pendingIceCandidates[userName] = [];
}

// function call from Java
function pushIceCandidateInPending(iceCandidates, userName) {
    if (!pendingIceCandidates[userName])
        pendingIceCandidates[userName] = [];

    iceCandidates.forEach(candidate => {        
        if (pendingIceCandidates[userName].indexOf(JSON.stringify(candidate)) === -1) {            
            pendingIceCandidates[userName].push(candidate);
        }
        else
            console.log("Duplicate ICE Candidate skipped: " + candidate);
    });
}