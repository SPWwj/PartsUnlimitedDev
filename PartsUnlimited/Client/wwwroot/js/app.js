//window.twttr = (function (d, s, id) {
//    var js, fjs = d.getElementsByTagName(s)[0],
//        t = window.twttr || {};
//    if (d.getElementById(id)) return t;
//    js = d.createElement(s);
//    js.id = id;
//    js.src = "https://platform.twitter.com/widgets.js";
//    fjs.parentNode.insertBefore(js, fjs);

//    t._e = [];
//    t.ready = function (f) {
//        t._e.push(f);
//    }; 
//    return t;
//}(document, "script", "twitter-wjs"));
function initMap() {
    var elements = document.querySelectorAll('.js-map');
    Array.prototype.forEach.call(elements, function (el) {
        var lat = +el.dataset.latitude,
            lng = +el.dataset.longitude,
            zoom = +el.dataset.zoom;

        if ((lat !== '') && (lng !== '') && (zoom > 0)) {
            var map = new google.maps.Map(el, {
                zoom: zoom,
                center: { lat: lat, lng: lng },
                disableDefaultUI: false,
                
            });

            var marker = new google.maps.Marker({
                map: map,
                animation: google.maps.Animation.DROP,
                position: { lat: lat, lng: lng }
            });
        }
    });
}
