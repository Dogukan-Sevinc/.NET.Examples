console.log("4.js dosyası çalıştı")

//GeoLocation

var initMap = () => {
    if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(showPosition);
    } else {
        console.log("Geolocation is not supported by this browser.");
    }
}
var showPosition = (position) => {
    console.log(position);
}


// latitude: 41.844008982786345
// longitude: 29.007230753851537



