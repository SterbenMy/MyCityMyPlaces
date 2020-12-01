let infoWindow, map, marker
// Initialize and add the map
function initMap() {
    // The location of Romanian Palace of Parliament
    const parliament = { lat: 44.4232, lng: 26.0858 };
    // The map, centered at Parliament
    map = new google.maps.Map(document.getElementById("map"), {
    zoom: 16,
    center: parliament,
    });
    // The marker, positioned at Parliament
    marker = new google.maps.Marker({
    position: parliament,
    map: map,
    });
    map.addListener("click", (e) => {
        placeMarkerAndPanTo(e.latLng, map);
    });
    infoWindow = new google.maps.InfoWindow();
    const locationButton = document.createElement("button");
    locationButton.textContent = "Current Location";
    locationButton.classList.add("custom-map-control-button");
    map.controls[google.maps.ControlPosition.TOP_CENTER].push(locationButton);
    locationButton.addEventListener("click", () => {
        // Try HTML5 geolocation.
        if (navigator.geolocation) {
            navigator.geolocation.getCurrentPosition(
                (position) => {
                    const pos = {
                        lat: position.coords.latitude,
                        lng: position.coords.longitude,
                    };
                    infoWindow.setPosition(pos);
                    infoWindow.setContent("Location found.");
                    infoWindow.open(map);
                    map.setCenter(pos);
                },
                () => {
                    handleLocationError(true, infoWindow, map.getCenter());
                }
            );
        } else {
            // Browser doesn't support Geolocation
            handleLocationError(false, infoWindow, map.getCenter());
        }
    });
}

function handleLocationError(browserHasGeolocation, infoWindow, pos) {
    infoWindow.setPosition(pos);
    infoWindow.setContent(
        browserHasGeolocation
            ? "Error: The Geolocation service failed."
            : "Error: Your browser doesn't support geolocation."
    );
    infoWindow.open(map);
}
function placeMarkerAndPanTo(latLng, map) {
    if (marker && marker.setMap) {
        marker.setMap(null);
    }
    marker = new google.maps.Marker({
        position: latLng,
        map: map,
    });
    map.panTo(latLng);
}
function addLocation(){
    let data = marker.getPosition();
    new google.maps.Marker({
        position: data,
        map: map,
    });
    map.panTo(data);
}
function showLocations(){}