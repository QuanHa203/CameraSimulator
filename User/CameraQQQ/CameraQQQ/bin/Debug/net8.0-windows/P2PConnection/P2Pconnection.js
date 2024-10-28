const cameraVideoStreamElement = document.getElementById("camera-video-stream");

const sender = RTCPeerConnection();

navigator.mediaDevices.getUserMedia({audio: true})
    .then(stream => {
        
    });