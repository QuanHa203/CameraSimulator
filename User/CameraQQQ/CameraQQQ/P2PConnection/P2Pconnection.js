const cameraVideoStreamElement = document.getElementById("camera-video-stream");

const sender = new RTCPeerConnection();
const dataChannel = sender.createDataChannel("Channel");

navigator.mediaDevices.getUserMedia({ audio: true })
    .then(stream => {
        stream.getTracks().forEach(track => sender.addTrack(track, stream));
    })

    .catch(e => console.log(e));

sender.ontrack = (event) => {    
    cameraVideoStreamElement.srcObject = event.streams[0];
}