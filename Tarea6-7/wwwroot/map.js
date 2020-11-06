function GetMap(json) {
    var map = L.map('mapid').setView([18.735693, -70.162651], 8);

    L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
        attribution: '&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors'
    }).addTo(map);

    var data = JSON.parse(json);
    alert(data);

    
}