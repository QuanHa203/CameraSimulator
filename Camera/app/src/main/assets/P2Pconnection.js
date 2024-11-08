const servers = {
    iceServers: [
        {
            urls: [
                'stun:stun.l.google.com:19302',
                'stun:stun1.l.google.com:19302',
                'stun:stun2.l.google.com:19302'
            ],
        },
    ],
    iceCandidatePoolSize: 10,
};
const camera = new RTCPeerConnection(servers);
const soundFromSender = document.getElementById("sound-from-sender");

navigator.mediaDevices.getUserMedia({ video: { facingMode: "environment", frameRate: { ideal: 60, max: 60 }, aspectRatio: 16 / 9 }, audio: true })
    .then(stream => {
        document.getElementById('local-video-stream').srcObject = stream;
        stream.getTracks().forEach(track => camera.addTrack(track, stream));
    });

camera.onicecandidate = (ev) => {
    if (ev.candidate) {
        // Send ICE Candidate to Anroid
        Android.receiveIceCandidate(JSON.stringify(ev.candidate));
    }
}

camera.ontrack = ev => {
    console.log(ev.streams[0]);
    soundFromSender.srcObject = ev.streams[0];
}

function setOfferFromSender(offer) {
    camera.setRemoteDescription(offer)
        .then(v => {
            createAnswer()
        })
        .catch(err => {
            console.log("Error: " + err);
            // setOfferFromSender(offer);
        })
}

function createAnswer() {
    camera.createAnswer()
        .then(answer => {
            // Set answer created
            camera.setLocalDescription(answer)
                .then(v => {
                    sendAnswerToAndroid();
                })
                .catch(err => {
                    console.log("Error: " + err);
                })
        })
        .catch(err => {
            console.log("Error: " + err);
            // if(camera.localDescription == null)
            //     createAnswer();
        })
}

function sendAnswerToAndroid() {
    // Send answer to Android
    Android.receiveAnswer(JSON.stringify(camera.localDescription));
    console.log(camera);
}

function setIceCandidateFromSender(iceCandidates) {
    for (let candidate of iceCandidates) {
        const iceCandidate = new RTCIceCandidate(candidate);
        // Thêm vào peerConnection
        camera.addIceCandidate(iceCandidate)
            .then(v => {

            })
            .catch(err => {
                console.error("Error adding ICE candidate:", err);
            })
    }
}

camera.oniceconnectionstatechange = () => {
    console.log("ICE Connection State:", camera.iceConnectionState);

    if (camera.iceConnectionState === "disconnected") {
        camera.close();        
        Android.disconnect();        
        Android.refreshActivity();
    }
    
};

camera.onicegatheringstatechange = () => {
    console.log("ICE Gathering State:", camera.iceGatheringState);
}