$(document).ready(function(){
    if("geolocation" in navigator){
        navigator.geolocation.getCurrentPosition(function(position){
        $("#Longitude").val(position.coords.longitude);
        $("#Latitude").val(position.coords.latitude);
        
        var currentTime = new Date();
        $('#SpotTime').val(currentTime.toLocaleString());
        });
    } else {
        alert("Geolocate NOT found.");
    }
    });