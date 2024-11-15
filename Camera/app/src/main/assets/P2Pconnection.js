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

            // Send request disconnect to Android
            Android.disconnect(userName);
        }
    };

    setOfferFromSender(offer, userName)
}

// function call from Java
function setIceCandidateFromSender(iceCandidates, userName) {
    console.log(iceCandidates);
    for (let candidate of iceCandidates) {
        // Thêm vào peerConnection
        peerConnections[userName].addIceCandidate(candidate)
            .then()
            .catch(err => console.error("Error adding ICE candidate:", err))
    }
}

function setOfferFromSender(offer, userName) {
    peerConnections[userName].setRemoteDescription(offer)
        .then(v => createAnswer(userName))
        .catch(err => console.log("Error: " + err))
}

function createAnswer(userName) {
    peerConnections[userName].createAnswer()
        .then(answer => {
            // Set answer created
            peerConnections[userName].setLocalDescription(answer)
                .then(v => {
                    // Send answer to Android
                    Android.receiveAnswer(JSON.stringify(peerConnections[userName].localDescription), userName);
                })
                .catch(err => {
                    console.log("Error: " + err);
                })
        })
        .catch(err => console.log("Error: " + err))
}