console.log("4.js dosyası çalıştı")

//GeoLocation

var getLocation = () => {
    if(navigator.geolocation){
        navigator.geolocation.getCurrentPostion(showPosition);
    }else{
        console.log("Geolocation is not supported by this browser.");
    }

var showPosition = (position) => {
    console.log(position);
}
}
