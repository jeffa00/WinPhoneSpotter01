$(document).ready(function(){
    if("geolocation" in navigator){
        //alert("Geolocate found.");
        navigator.geolocation.getCurrentPosition(function(position){
        $("#Longitude").val(position.coords.longitude);
        $("#Latitude").val(position.coords.latitude);
        
        var currentTime = new Date();
        var currentTimeDisplay = currentTime.toLocaleString();
        
        $('#SpotTime').val(currentTimeDisplay);
        });
    } else {
        alert("Geolocate NOT found.");
    }
    });