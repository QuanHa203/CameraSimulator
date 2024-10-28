const receiver = new RTCPeerConnection();
let dataChannel = null;

navigator.mediaDevices.getUserMedia({ video: { facingMode: "environment", frameRate: { ideal: 60, max: 60 }, aspectRatio: 16 / 9 }, audio: true })
    .then(stream => {
        document.getElementById('local-video-stream').srcObject = stream;
        stream.getTracks().forEach(track => receiver.addTrack(track, stream));
    });

receiver.onicecandidate = (e) => {
    _currentOffer = receiver.localDescription;
    
}

receiver.ondatachannel = (e) => {
    dataChannel = e.channel;
    dataChannel.onmessage = (e) => alert(`Just got a message: ${e.data}`);
    dataChannel.onopen = (e) => alert(`Connection opened!`);
}

async function fillOffer(offerFromSender) {
    try {
        // Fill offer from sender
        await receiver.setRemoteDescription(JSON.parse(offerFromSender))

        // Create offer
        const answer = await receiver.createAnswer();
        receiver.setLocalDescription(answer);

    }
    catch (ex) {
        alert(ex);
    }
}

function hello() {
    alert("Hello")
}