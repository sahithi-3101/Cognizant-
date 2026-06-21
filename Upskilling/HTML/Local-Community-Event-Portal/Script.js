window.onbeforeunload = function () {
    return "You may have unsaved changes.";
};

function validatePhone() {
    const phone = document.getElementById("phone").value.trim();

    if (phone.length < 10) {
        alert("Please enter a valid phone number.");
    }
}

function showFee() {
    const selected = document.getElementById("eventType").value;
    const fee = document.getElementById("fee");

    const fees = {
        "Workshop": "Fee: ₹200",
        "Clean-Up Drive": "Fee: Free",
        "Health Camp": "Fee: ₹100"
    };

    fee.textContent = fees[selected] || "";
}

function showConfirmation(event) {
    event.preventDefault();

    document.getElementById("confirmation").textContent =
        "Registration submitted successfully!";
}

function enlargeImage(img) {
    if (img.style.transform === "scale(1.5)") {
        img.style.transform = "scale(1)";
    } else {
        img.style.transform = "scale(1.5)";
    }
}

function countCharacters() {
    const count = document.getElementById("feedbackText").value.length;

    document.getElementById("charCount").textContent = count;
}

function videoReady() {
    document.getElementById("videoMessage").textContent =
        "Video ready to play.";
}

function savePreference() {
    const eventType = document.getElementById("eventType").value;

    localStorage.setItem("preferredEvent", eventType);
}

window.onload = function () {
    const savedEvent = localStorage.getItem("preferredEvent");

    if (savedEvent) {
        document.getElementById("eventType").value = savedEvent;
        showFee();
    }
};

function clearPreferences() {
    localStorage.clear();
    sessionStorage.clear();

    alert("Preferences cleared.");
}

function findLocation() {
    const options = {
        enableHighAccuracy: true,
        timeout: 5000
    };

    navigator.geolocation.getCurrentPosition(
        function (position) {
            document.getElementById("coordinates").textContent =
                `Latitude: ${position.coords.latitude}, Longitude: ${position.coords.longitude}`;
        },
        function (error) {
            document.getElementById("coordinates").textContent =
                `Error: ${error.message}`;
        },
        options
    );
}

console.log("Local Community Event Portal Loaded Successfully");