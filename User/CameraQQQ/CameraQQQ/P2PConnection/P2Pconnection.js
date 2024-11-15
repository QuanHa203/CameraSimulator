const servers = {
    iceServers: [
        {
            urls: [
                'stun:stun.l.google.com:19302',
                //'stun:stun1.l.google.com:19302',
                //'stun:stun2.l.google.com:19302'
            ],
        },
    ],
    iceCandidatePoolSize: 10,
};

const sender = new RTCPeerConnection(servers);
const callCSharp = chrome.webview.hostObjects.callCSharp;

let pendingCandidates = [];
let cameraVideoStream = document.getElementById("camera-video-stream");
let audioTrack = null;

navigator.mediaDevices.getUserMedia({ audio: true, video: true })
    .then(mediaStream => {
        audioTrack = mediaStream.getAudioTracks()[0];
        audioTrack.enabled = false;

        mediaStream.getTracks().forEach(stream => {
            sender.addTrack(stream, mediaStream);
            window.chrome.webview.postMessage("Granted");
        })
    })
    .catch(err => {
        // alert("Error: " + err)
        window.chrome.webview.postMessage("Denied");
    });

sender.ontrack = (ev) => {
    cameraVideoStream.srcObject = ev.streams[0];
    cameraVideoStream.style.transform = "rotate(-90deg)";
};

sender.onicecandidate = (ev) => {
    if (ev.candidate) {
        // Send candidate to Firebase
        callCSharp.SetIceCandidateUser(JSON.stringify(ev.candidate));
    }
};

sender.oniceconnectionstatechange = async () => {
    console.log("ICE Connection State:", sender.iceConnectionState);
    if (sender.iceConnectionState === "connected") {
        callCSharp.NotifyCameraConnected();
    }

    if (sender.iceConnectionState === "disconnected") {
        sender.close();
        callCSharp.NotifyCameraDisconnected();
    }
};

// Call via C#
function createOffer() {
    // Create Offer
    sender.createOffer()
        .then(offer => {

            // Save offer to RTCPeerConnection
            sender.setLocalDescription(offer)
                .then(v => {
                    // Set offer to save in firebase
                    if (sender.localDescription != null)
                        callCSharp.SetOffer(JSON.stringify(sender.localDescription));
                })
                .catch(err => console.log(err));
        })
        .catch(err => console.log("Error Set Offer: " + err));
}

// Call via C#
function setAnswerFromCamera(answer) {    
    sender.setRemoteDescription(answer)
        .then(v => {
            pendingCandidates.forEach(candidate => sender.addIceCandidate(candidate));
            pendingCandidates = []; // Xóa danh sách sau khi đã thêm            
        })
        .catch(err => {
            console.log("setRemoteDescription fail - Error: " + err)
        });
}

// Call via C#
function setIceCandidateFromCamera(candidate) {    
    if (sender.remoteDescription) {
        sender.addIceCandidate(JSON.parse(candidate))
            .then()
            .catch(err => console.log(err));
    }
    else {
        pendingCandidates.push(JSON.parse(candidate));
    }
}

// Call via C#
function turnOnVolume() {
    cameraVideoStream.muted = false;
}

// Call via C#6
function turnOffVolume() {
    cameraVideoStream.muted = true;
}

// Call via C#
function turnOnMicro() {
    if (audioTrack == null)
        return;

    audioTrack.enabled = true;
}

// Call via C#
function turnOffMicro() {
    if (audioTrack == null)
        return;

    audioTrack.enabled = false;
}
