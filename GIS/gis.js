$(document).ready(function() {
	/*Calling scripts API*/
	/*Google Maps API*/
	$.getScript('https://maps.googleapis.com/maps/api/js?key=AIzaSyAEslfwKJo0N4lfsbZLwrSFzd7ic2e5Kz0&libraries=visualization')
	
	/*Bing Maps API*/
	$.getScript('https://www.bing.com/api/maps/mapcontrol') 
	
	/*Leaflet CSS API*/
	$('<link/>', {
	   rel: 'stylesheet',
	   type: 'text/css',
	   href: 'https://unpkg.com/leaflet@1.6.0/dist/leaflet.css'
	}).appendTo('head');
	/*Leaflet Javascript API*/
	$.getScript('https://unpkg.com/leaflet@1.6.0/dist/leaflet.js')
	
	/*Openlayers CSS API*/
	$('<link/>', {
	 rel: 'stylesheet',
	 type: 'text/css',
	 href: 'resources/ol.css'
	}).appendTo('head');
	/*Openlayers javascript API*/
	$.getScript('resources/ol.js')
	

	
	var oldState = $("#map_space").clone() //sets the old map space 
	
	$("#checkboxOnOff").hide();
	$("#map_space2").hide();
	$(".btnAnimations").hide();
	
	//Used only when the part 21 link is clicked
	$('.links').on('click', 'a:not("#part21")',function(){
		$("#checkboxOnOff").hide();
	});
	//Used only whenthe part 22 link is clicked
	$('.links').on('click', 'a:not("#part22")',function(){
		$("#map_space2").hide();
	});
	//Used only when the part 23 link is clicked
	$('.links').on('click', 'a:not("#part23")',function(){
		$(".btnAnimations").hide();
	});
	
	
	/*Sidemenu close/open*/
	var state = false;
	
	$(".sidemenuImage").click(function(){

	
	if (state === false){
		state = true;

		$(".links").animate({marginLeft:"-180px"},400,function(){
		$(".dropdown-menu").css({"margin-left":"40px"})
		});

	} else  {
		state = false;
		
		$(".links").animate({marginLeft:"0px"},400,function(){
		$(".dropdown-menu").css({"margin-left":"220px"})
		});
	}
	});
		
		
	


/***********************Google Maps*************************/

/*Part 1*/
$("#part1").click(function(){
	 $("#map_space").replaceWith(oldState.clone());
	 $("h1").html("Part 1 Welsh Map");
	  var map_Ops = {
	  center:new google.maps.LatLng(52.417, -3.573),
	  zoom:8,
	  mapTypeId:google.maps.MapTypeId.roadmap,
	
	  };
	  
	  
	  var map = new google.maps.Map(document.getElementById("map_space"),map_Ops);
	  var myStyles= [
	{
		featureType: 'water',	
		elementType: 'all',
		stylers: [
		  {color: '#fc0b03'},
		  {visibility: 'on'},]
	}
	
	]
	var styledMapType = new google.maps.StyledMapType(myStyles,{
      map: map,
      name: 'Styled Map'
    });
	
	map.mapTypes.set('Styled_Map', styledMapType);
	map.setMapTypeId('Styled_Map');
	
});
	
/*Part 2*/
$("#part2").click(function(){
	 $("#map_space").replaceWith(oldState.clone());
	 $("h1").html("Part 2 Welsh Castle");
 var map_Ops = {
	  center:new google.maps.LatLng(52.299503, -3.432477),
	  zoom:8,
	  mapTypeId:google.maps.MapTypeId.roadmap//type of google map
	  };
	  var map = new google.maps.Map(document.getElementById("map_space"),map_Ops);
	  
	  var map_centre = map.getCenter();

	  
	  
	  
	  //custom marker
	  var mkr_image = {
	  url: 'https://ces-web2.southwales.ac.uk/students/17144159/resources/Images/Castle-icon.png',
      //size: new google.maps.Size(50,50),
	  scaledSize: new google.maps.Size(10,15),
      origin: new google.maps.Point(0,0),
      anchor: new google.maps.Point(0,0)
	  };
	  
	  //castles 
	  var loc = new google.maps.LatLng(51.482672,-3.181134);
	  var mkr_ops = {position:loc, map:map, icon:mkr_image, animation: google.maps.Animation.BOUNCE, MarkerLabel:'Cardiff Castle' };
	  var mkr = new google.maps.Marker(mkr_ops);
	
	  
	  var loc1 = new google.maps.LatLng(51.677012, -4.920601);
	  var mkr_ops = {position:loc1, map:map, icon:mkr_image, animation: google.maps.Animation.BOUNCE, MarkerLabel:'Pembroke Castle' };
	  var mkr = new google.maps.Marker(mkr_ops);
	  
	  var loc2 = new google.maps.LatLng(51.535846,-3.254822);
	  var mkr_ops = {position:loc2, map:map, icon:mkr_image, animation: google.maps.Animation.BOUNCE, MarkerLabel:'Castell Coch'};
	  var mkr = new google.maps.Marker(mkr_ops);
		
});
/*Part 3*/
$("#part3").click(function(){
	 $("#map_space").replaceWith(oldState.clone());
	 $("h1").html("Part 3 Cardiff Aiport Destinations");
	 var map_Ops = {
	  center:new google.maps.LatLng(53.219254, -1.726138),
	  zoom:6,
	  mapTypeId:'hybrid'//type of google map
	  };
	  var map = new google.maps.Map(document.getElementById("map_space"),map_Ops);
	  
	  var map_centre = map.getCenter();

	  
	  
	var my_path = [ /*Destinations from cardiff airport*/
	{lat:51.398302,lng: -3.345468},/*Dublin*/
	{lat:53.350008,lng: -6.258678},
	{lat:51.398302,lng: -3.345468},/*Edinburgh*/
	{lat:55.954232,lng: -3.187455},
	{lat:51.398302,lng: -3.345468},/*Leeds*/
	{lat:53.804972,lng: -1.547697},
	{lat:51.398302,lng: -3.345468},/*Bangor*/
	{lat:53.227671,lng: -4.129810},	
	{lat:51.398302,lng: -3.345468},/*Southampton*/
	{lat:50.910247,lng: -1.403414},	
	{lat:51.398302,lng: -3.345468},/*Stanstead*/
	{lat:51.905404,lng: 0.195597},	
	{lat:51.398302,lng: -3.345468},/*Exeter*/
	{lat:50.720293,lng: -3.534663},	
		];							
	var plotline = new google.maps.Polyline({
	path: my_path,
	strokeColor: '#ceff08',
	strokeOpacity: 0.7,
	editable: true,
	strokeWeight: 4
	});
	
	plotline.setMap(map);	
});
/*Part 4*/
$("#part4").click(function(){
	 $("#map_space").replaceWith(oldState.clone());
	 $("h1").html("Part 4 Polygon Shapes");
	 var map_Ops = {
	  center:new google.maps.LatLng(53.219254, -1.726138),
	  zoom:6,
	  mapTypeId:google.maps.MapTypeId.roadmap//type of google map
	  };
	  var map = new google.maps.Map(document.getElementById("map_space"),map_Ops);
	  
	  var map_centre = map.getCenter();
	  
	  var area1 = [
		{lat:51.86,lng: -3.95},
		{lat:51.93,lng: -3.85},
		{lat:52.01,lng: -3.72},
		{lat:51.96,lng: -3.65},					
		{lat:51.87,lng: -3.60},
		{lat:51.86,lng: -3.76},
		{lat:51.84,lng: -3.91},
		{lat:51.86,lng: -3.95}	
		];		
		var plots = new google.maps.Polygon({
		path: area1,
		strokeColor: '#0000FF',
		strokeOpacity: 0.7,
		strokeWeight: 5
		});
		plots.setMap(map);	
		 

		var area2 = [
		{lat:53.10,lng: -3.90},
		{lat:52.81,lng: -3.59},
		{lat:52.75,lng: -3.82},
		{lat:52.83,lng: -4.05},
		{lat:53.10,lng: -3.90}
		];

		var plots = new google.maps.Polygon({
		path: area2,
		strokeColor: '#0000FF',
		strokeOpacity: 0.7,
		strokeWeight: 5
		});
		plots.setMap(map);	
});
/*Part 5*/
$("#part5").click(function(){
	 $("#map_space").replaceWith(oldState.clone());
	 $("h1").html("Part 5 Stadiums");
	var map_Ops = {
	  center:new google.maps.LatLng(51.730305, -3.755390),
	  zoom:9,
	  mapTypeId:google.maps.MapTypeId.roadmap//type of google map
	  };
	  

	var map = new google.maps.Map(document.getElementById("map_space"),map_Ops);

	  
	var map_centre = map.getCenter();
	
	var mkr1 = new google.maps.Marker({
	 position:{lat:51.478,lng: -3.182},
	 title:'Principality Stadium',
	 map:map});
	
	var mkr2 = new google.maps.Marker({
	 position:{lat:51.642,lng: -3.935},
	 title:'Liberty Stadium',
	 map:map});

	var iw1 = new google.maps.InfoWindow({
	 content: '<b>Principality Stadium</b><br>'+
	 '<a href="https://www.principalitystadium.wales/"> Wiki </a>',
	 position:{lat:51.478,lng:-3.182}
	 });
	
	var iw2	= new google.maps.InfoWindow({
	 content: '<b>Liberty Stadium</b><br>'+
	 '<a href="https://www.liberty-stadium.com/"> Wiki </a>',
	 position:{lat:51.642,lng:-3.935}
	 });
	
	 google.maps.event.addListener(mkr1,'click',function(){
	 map.panTo(mkr1.position);
	 map.setZoom(10);
	 iw1.open(map,mkr1);
	 });
	 google.maps.event.addListener(mkr2,'click',function(){
	 map.panTo(mkr2.position);
	 map.setZoom(10);
	 iw2.open(map,mkr2);
	 });
	 
});
/*Part 6*/
$("#part6").click(function(){
	 $("#map_space").replaceWith(oldState.clone());
	 $("h1").html("Part 6 Controls");
	var map_Ops = {
	  center:new google.maps.LatLng(51.730305, -3.755390),
	  zoom:9,
	  mapTypeId:google.maps.MapTypeId.roadmap,//type of google map
	  disableDefaultUI: true, 
	  zoomControl:true,
	  mapTypeControl: true,
	  mapTypeControlOptions: {
		style: google.maps.MapTypeControlStyle.DROPDOWN_MENU,
		position: google.maps.ControlPosition.TOP_CENTER
		},
		zoomControl: true,
	   zoomControlOptions: {
		style: google.maps.ZoomControlStyle.SMALL,
		position: google.maps.ControlPosition.LEFT_CENTER} /*Zoom buttons are located left middle of the map*/
	
	};
	
	  

	var map = new google.maps.Map(document.getElementById("map_space"),map_Ops);

	  
	var map_centre = map.getCenter();
});
/*Part 7*/
$("#part7").click(function(){
	 $("#map_space").replaceWith(oldState.clone());
	 $("h1").html("Part 7 KML Created File");
	 var map_Ops = {
	  center:new google.maps.LatLng(52.417, -3.573),
	  zoom:8,
	  mapTypeId:google.maps.MapTypeId.roadmap,
	
	  };
	  var map = new google.maps.Map(document.getElementById("map_space"),map_Ops);
	  var src ="https://ces-web2.southwales.ac.uk/students/17144159/resources/data/Test.kml?dummy="  + (new Date()).getTime(); /*Google Earth KML export and also the bit in the end will avoid caching*/
	 
	  var kmlLayer = new google.maps.KmlLayer(src, {
	  preserveViewport: true,
	  map: map
	  });
	  
});
/*Part 8*/
$("#part8").click(function(){
	 $("#map_space").replaceWith(oldState.clone());
	 $("h1").html("Part 8 KML Imported File");
	 var map_Ops = {
	  center:new google.maps.LatLng(52.417, -3.573),
	  zoom:8,
	  mapTypeId:google.maps.MapTypeId.roadmap,
	
	  };
	  var map = new google.maps.Map(document.getElementById("map_space"),map_Ops);
	  
	 var kmlLayer = new google.maps.KmlLayer('https://gis.beacons-npa.gov.uk/geoserver/inspire/ows?service=WFS&version=1.0.0&request=GetFeature&typeName=inspire:brecon_beacons_national_park_authority_owned_land&outputFormat=kml',
 				 {map: map, preserveViewport: true});

});
/*extra map 1*/
$("#extra1").click(function(){
	 $("#map_space").replaceWith(oldState.clone());
	 $.when(
	$.getScript('https://ces-web2.southwales.ac.uk/students/17144159/resources/geoxml3.js'), 	 /*GeoXML plugin*/
	$.getScript('https://ces-web2.southwales.ac.uk/students/17144159/resources/googleStyles.js'), //styling stored in javascript file
		$.Deferred(function(deferred){
		$(deferred.resolve);
	})
	).done(function(){
	 $("h1").html("Extra Map i(Customization)");
	  var map_Ops = {
	  mapTypeId:google.maps.MapTypeId.roadmap,
	  styles: theStyle //calls styling 
	  };
	  var wales ={lat:51.476151, lng: -3.328723};
	  function CenterControl(controlDiv, map) {

        // Set CSS for the control border.
        var controlUI = document.createElement('div');
        controlUI.style.backgroundColor = '#fff';
        controlUI.style.border = '2px solid #fff';
        controlUI.style.borderRadius = '3px';
        controlUI.style.boxShadow = '0 2px 6px rgba(0,0,0,.3)';
        controlUI.style.cursor = 'pointer';
        controlUI.style.marginBottom = '22px';
        controlUI.style.textAlign = 'center';
        controlUI.title = 'Click to recenter the map';
        controlDiv.appendChild(controlUI);

        // Set CSS for the control interior.
        var controlText = document.createElement('div');
        controlText.style.color = 'rgb(25,25,25)';
        controlText.style.fontFamily = 'Roboto,Arial,sans-serif';
        controlText.style.fontSize = '16px';
        controlText.style.lineHeight = '38px';
        controlText.style.paddingLeft = '5px';
        controlText.style.paddingRight = '5px';
        controlText.innerHTML = 'Center Map';
        controlUI.appendChild(controlText);

        // Setup the click event listeners: simply set the map to Chicago.
        controlUI.addEventListener('click', function() {
          map.setCenter(wales);
		  map.setZoom(11)
        });

      }
	  	  
	  var map = new google.maps.Map(document.getElementById("map_space"),map_Ops);
	  
        var centerControlDiv = document.createElement('div');
        var centerControl = new CenterControl(centerControlDiv, map);

        centerControlDiv.index = 1;
        map.controls[google.maps.ControlPosition.TOP_CENTER].push(centerControlDiv);
		
	   var src ="https://ces-web2.southwales.ac.uk/students/17144159/resources/data/Castle.kml?dummy="  + (new Date()).getTime(); /*Google Earth KML export and also the bit in the end will avoid caching*/
	     
		 /*Setting marker from kml file*/
		var geoXml = new geoXML3.parser({
        map: map,
        singleInfoWindow: true,
		markerOptions: {
			icon:"http://maps.google.com/mapfiles/ms/micons/blue.png"
		}
    });
    geoXml.parse(src);//show all markers from marker
	
	});

	
});
/*extra map 2*/
$("#extra2").click(function(){
	$("#map_space").replaceWith(oldState.clone());
	$("h1").html("Extra Map ii(Self Sourced Spatial Data)");
	$.when(
	$.getScript('https://ces-web2.southwales.ac.uk/students/17144159/resources/data/pharmacies.js'),
	$.getScript('https://ces-web2.southwales.ac.uk/students/17144159/resources/data/HeritageCoasts.js'),
	$.Deferred(function(deferred){
	$(deferred.resolve);
	})
	).done(function(){
	
	  var map_Ops = {
	  center:new google.maps.LatLng(52.417, -3.573),
	  zoom:8,
	  mapTypeId:google.maps.MapTypeId.roadmap
	};
	  var map = new google.maps.Map(document.getElementById("map_space"),map_Ops);
	  map.data.addGeoJson(myGeoJson);//Pharmacies
	  map.data.addGeoJson(myGeoJson2);//Heritage coasts
	  map.data.setMap(map);
	   

	  
	  
/*  var src ="https://ces-web2.southwales.ac.uk/students/17144159/resources/data/FloodAlertAreas.kml?dummy="  + (new Date()).getTime(); /*Google Earth KML export and also the bit in the end will avoid caching*/
  /*Setting marker from kml file*/
		/* var geoXml = new geoXML3.parser({
        map: map,
        singleInfoWindow: true,
		});
	    geoXml.parse(src);
	/
	map.data.addGeoJson(myGeoJson); //GeoJSON data Flooding
	map.data.setMap(map);
	//}); 
	});
});
*/
});
});

/***********************Bing Maps*************************/
/*Part 9*/
$("#part9").click(function(){
	 $("#map_space").replaceWith(oldState.clone());
	 $("h1").html("Part 9 Bing Map");
	 
	var map_Ops = {
	  credentials: 'Al1QNytKCYGCkyQHdVj7FuLBlNbP3UK5pgCXKQHveVhoWGBS9mvKg12n0UU3G5fk',
	  center:new Microsoft.Maps.Location(51.478, -3.182),
	  zoom:8,
	  mapTypeId:Microsoft.Maps.MapTypeId.roadmap
	  
	  };
	
	var map = new Microsoft.Maps.Map(document.getElementById("map_space"),map_Ops);
	var Point1 = new Microsoft.Maps.Location(51.478, -3.182);
	var Point2 = new Microsoft.Maps.Location(51.642, -3.935);
	
	var mkr1 = new Microsoft.Maps.Pushpin(Point1,{
	});
	var mkr2 = new Microsoft.Maps.Pushpin(Point2,{
	});
	var polygon = new Microsoft.Maps.Polygon([Point1,Point2])
	
	var infobox = new Microsoft.Maps.Infobox(Point1, {
         title: 'Millenium Stadium',
         description: 'Welsh RFC Stadium'
        });
	

    map.entities.push(mkr1);
	map.entities.push(mkr2);
	map.entities.push(polygon);
	map.entities.push(infobox);
});
/*Part 10*/
$("#part10").click(function(){
	$("#map_space").replaceWith(oldState.clone());
	$("h1").html("Part 10 GeoJSON with Bing Map");
	$.getScript('https://ces-web2.southwales.ac.uk/students/17144159/resources/data/coordinates.js') .done(function(){
	var map_Ops = {
	  credentials: 'Al1QNytKCYGCkyQHdVj7FuLBlNbP3UK5pgCXKQHveVhoWGBS9mvKg12n0UU3G5fk',
	  center:new Microsoft.Maps.Location(51.478, -3.182),
	  zoom:8,
	  mapTypeId:Microsoft.Maps.MapTypeId.roadmap

	

     };
	var map = new Microsoft.Maps.Map(document.getElementById("map_space"),map_Ops);
	Microsoft.Maps.loadModule('Microsoft.Maps.GeoJson', function () {
      //Parse the GeoJson object into a Bing Maps shape.
      var shape = Microsoft.Maps.GeoJson.read(myGeoJson, {
        pointOptions: {
		color:'blue'
        }
     });
	map.entities.push(shape);
	});
	
	});
 
});
/*Part 11*/
$("#part11").click(function(){
	 $("#map_space").replaceWith(oldState.clone());
	 $("h1").html("Part 11 GeoJSON Welsh National Parks");
	$.getScript('https://ces-web2.southwales.ac.uk/students/17144159/resources/data/Bounderies.js').done(function(){
	 var map_Ops = {
	  credentials: 'Al1QNytKCYGCkyQHdVj7FuLBlNbP3UK5pgCXKQHveVhoWGBS9mvKg12n0UU3G5fk',
	  center:new Microsoft.Maps.Location(51.478, -3.182),
	  zoom:8,
	  mapTypeId:Microsoft.Maps.MapTypeId.roadmap
	  
	  };
	
	var map = new Microsoft.Maps.Map(document.getElementById("map_space"),map_Ops);
	  	Microsoft.Maps.loadModule('Microsoft.Maps.GeoJson', function () {
	  //Parse the GeoJson object into a Bing Maps shape.
      var shape = Microsoft.Maps.GeoJson.read(myGeoJson, {
        pointOptions: {
		color:'blue'
        }
     });
	 map.entities.push(shape);
	});
	});
});
/*Extra Map iii*/
$("#extra3").click(function(){
	 $("#map_space").replaceWith(oldState.clone());
	 $("h1").html("Extra Map III");
		var map,
        maxPopulation = 1000,
        heatGradientData;
	 
	var map_Ops = {
	  credentials: 'Al1QNytKCYGCkyQHdVj7FuLBlNbP3UK5pgCXKQHveVhoWGBS9mvKg12n0UU3G5fk',
	  center:new Microsoft.Maps.Location(51.478, -3.182),
	  zoom:8,
	  mapTypeId:Microsoft.Maps.MapTypeId.roadmap
	  };
	  
	  var map = new Microsoft.Maps.Map(document.getElementById("map_space"),map_Ops);
		
		
		

		//Load the DrawingTools module
	Microsoft.Maps.loadModule('Microsoft.Maps.DrawingTools', function () {
		//Create an instance of the DrawingTools class and bind it to the map.
		var tools = new Microsoft.Maps.DrawingTools(map);

		//Show the drawing toolbar and enable editting on the map.
		tools.showDrawingManager(function (manager) {
			//Store a reference to the drawing manager as it will be useful later.
			drawingManager = manager;
		});
	});
	
	        //Load traffic module.
	Microsoft.Maps.loadModule('Microsoft.Maps.Traffic', function () {
		//Create an instance of the traffic manager and bind to map.
		trafficManager = new Microsoft.Maps.Traffic.TrafficManager(map);

		//Display the traffic flow and incident data.
		trafficManager.setOptions({ flowVisible: true, incidentsVisible: true, legendVisible: false });
	});
	
	Microsoft.Maps.loadModule(['Microsoft.Maps.GeoJson', 'Microsoft.Maps.HeatMap'], function () {
    Microsoft.Maps.GeoJson.readFromUrl('https://ces-web2.southwales.ac.uk/students/17144159/resources/data/dentists.json', function (shapes) {
        var heatMap = new Microsoft.Maps.HeatMapLayer(shapes, { radius: 10, propertyAsWeight: 'mag' });
        map.layers.insert(heatMap);
		});
	}); 


});
/***********************Leaflet*************************/
/*Part 12*/
$("#part12").click(function(){
	 $("#map_space").replaceWith(oldState.clone());
	 $("h1").html("Part 12 Leaflet Map");
	var mymap = L.map('map_space').setView([51.478, -3.182], 13);
	
	L.tileLayer('http://c.tile.stamen.com/watercolor/{z}/{x}/{y}.png').addTo(mymap);
	
	L.marker([51.642, -3.935], {title:'Liberty Stadium'},{draggable:'true'}).addTo(mymap); /*Swansea*/
	
	L.marker([51.478,-3.182],
	{title:'Millenium Stadium'},
	{draggable:'true'}).addTo(mymap);/*Cardiff*/
	
});
/*Part 13*/
$("#part13").click(function(){
	 $("#map_space").replaceWith(oldState.clone());
	 $("h1").html("Part 13 Mapbox Map");
	var mymap = L.map('map_space').setView([51.478, -3.182], 13);
	
	L.tileLayer('https://api.tiles.mapbox.com/v4/{id}/{z}/{x}/{y}.png?access_token=pk.eyJ1IjoiY2hpaG9vOTkiLCJhIjoiY2s2Nmk2bmdiMTE0MjNwbDJtNmh2Nm52dCJ9.aq_mB86ZFQ2XX07FWQK1OQ',
	{
	maxZoom: 18,
	id:'mapbox.streets'
	}).addTo(mymap);
	
	var swansea = L.marker([51.642, -3.935],{draggable:true}).addTo(mymap); /*Swansea*/

	swansea.bindPopup("Swansea").openPopup();
	
	var cardiff = L.marker([51.478,-3.182],
	{title:'Millenium Stadium'},
	{draggable:'true'}).addTo(mymap);/*Cardiff*/
	
	
	cardiff.bindPopup("Cardiff").openPopup();
	
	/*Video overlay*/
	var videoUrl = 'http://techslides.com/demos/sample-videos/small.webm',
    videoBounds = [[ 51.478,-3.182], [51.642, -3.935]];
	L.videoOverlay(videoUrl, videoBounds ).addTo(mymap);
	
	/*Line polygon*/
	var latlngs = [
    [45.51, -122.68],
    [37.77, -122.43],
    [34.04, -118.2]
	];
	var polyline = L.polyline(latlngs, {color: 'red'}).addTo(mymap);
	// zoom the map to the polyline
	mymap.fitBounds(polyline.getBounds());
});
/*Part 14*/
$("#part14").click(function(){
	$("#map_space").replaceWith(oldState.clone());
	$("h1").html("Part 14 geoJSON Welsh Boundaries Click Event");
	$.getScript('https://ces-web2.southwales.ac.uk/students/17144159/resources/data/Bounderies.js').done(function(){ //makes sure that the script is ran initailly when called
	
	
	var mymap = L.map('map_space').setView([51.478, -3.182], 13);
	L.tileLayer('https://api.tiles.mapbox.com/v4/{id}/{z}/{x}/{y}.png?access_token=pk.eyJ1IjoiY2hpaG9vOTkiLCJhIjoiY2s2Nmk2bmdiMTE0MjNwbDJtNmh2Nm52dCJ9.aq_mB86ZFQ2XX07FWQK1OQ',
	{
	maxZoom: 18,
	id:'mapbox.streets'
	}).addTo(mymap);
	
	function newStyle(feature){
		return{
			fillColor: '#FF00FF',
			fillOpacity: 0.5,
			COLOR: '#B04173',
			weight: 4,
		};
	}
		

	
	var contentLayer = L.geoJSON(myGeoJson,{style:newStyle});
	mymap.addLayer(contentLayer);
	
	var selection;
	function unclickedStyle(feature) {
		return{
			fillColor: "#00FFFF",
			fillOpacity: 0.5, 
			color: '#00FFFF',
			weight: 4
		};
	}
	
	function clickedStyle(feature) {
		return{
			fillColor: "#FFFF00",
			fillOpacity: 0.6, 
			color: '#FFFF00',
			weight: 4
		};
	}
	
	var contentLayer = L.geoJSON(myGeoJson,{
		style:unclickedStyle,
		onEachFeature: clickOnFeature
	})
	mymap.addLayer(contentLayer);
	
	
	function clickOnFeature(feature, layer){
		layer.on({
			click: function(e){
				if (selection) {
					contentLayer.resetStyle(selection);
				}
				e.target.setStyle(clickedStyle());
				selection = e.target;
				
				L.DomEvent.stopPropagation(e);
			}
		});
	}
		mymap.addEventListener('click',function(e) {
		if (selection) {
			contentLayer.resetStyle(selection);
			selection = null;
		}
	});
	
	});
});
/*Part 15*/
$("#part15").click(function(){
	$("#map_space").replaceWith(oldState.clone());
	$("h1").html("Part 15 Dentists geoJSON");
	$.getScript('https://ces-web2.southwales.ac.uk/students/17144159/resources/data/dentists.js').done(function(){
	
	var mymap = L.map('map_space').setView([51.478, -3.182], 13);
	
	
	
	L.tileLayer('https://api.tiles.mapbox.com/v4/{id}/{z}/{x}/{y}.png?access_token=pk.eyJ1IjoiY2hpaG9vOTkiLCJhIjoiY2s2Nmk2bmdiMTE0MjNwbDJtNmh2Nm52dCJ9.aq_mB86ZFQ2XX07FWQK1OQ',
	{
		maxZoom: 18,
		id:'mapbox.streets'
		}).addTo(mymap)
		L.geoJSON(myGeoJson).addTo(mymap);
	});
});
/*Part 16*/
$("#part16").click(function(){
	 $("#map_space").replaceWith(oldState.clone());
	 $("h1").html("Part 16 Leaflet geoJSON with Clustered markers");
	 
	 $.when(//Calling all plugins
	 $('<link/>', {
	   rel: 'stylesheet',
	   type: 'text/css',
	   href: 'https://ces-web2.southwales.ac.uk/students/17144159/resources/MarkerCluster.css'
	}).appendTo('head'),
	 $('<link/>', {
	   rel: 'stylesheet',
	   type: 'text/css',
	   href: 'https://ces-web2.southwales.ac.uk/students/17144159/resources/MarkerCluster.Default.css'
	}).appendTo('head'),
	 $.getScript('https://ces-web2.southwales.ac.uk/students/17144159/resources/leaflet.markercluster.js'), //calling markercluster css and javascript files
	 $.getScript('https://ces-web2.southwales.ac.uk/students/17144159/resources/data/hospitals.js'), //hospitals geoJSON dataset
	 $.Deferred(function(deferred){
		$(deferred.resolve);
	})
	).done(function(){
	var mymap = L.map('map_space').setView([51.478, -3.182], 13);
	
	L.tileLayer('https://api.tiles.mapbox.com/v4/{id}/{z}/{x}/{y}.png?access_token=pk.eyJ1IjoiY2hpaG9vOTkiLCJhIjoiY2s2Nmk2bmdiMTE0MjNwbDJtNmh2Nm52dCJ9.aq_mB86ZFQ2XX07FWQK1OQ',
	{
		maxZoom: 18,
		id:'mapbox.streets'
		}).addTo(mymap)


	
	var markers = L.markerClusterGroup({
		iconCreateFunction: function(cluster) {
		return L.divIcon({ html: '<b>' + cluster.getChildCount() + '</b>' });
		}
	});
	
	var geoJsonLayer = L.geoJson(myGeoJson, {
			onEachFeature: function (feature, layer) {
				layer.bindPopup(feature.properties.address);
			}
	});
	
	markers.addLayer(geoJsonLayer);

	mymap.addLayer(markers);
	mymap.fitBounds(markers.getBounds());
	});
});
/*Part 17*/
$("#part17").click(function(){
	$("#map_space").replaceWith(oldState.clone());
	 $("h1").html("Part 17 Leaflet Heatmap and Search");
	$.when(//Calling all plugins
	$('<link/>', {
	   rel: 'stylesheet',
	   type: 'text/css',
	   href: 'https://unpkg.com/leaflet-control-geocoder/dist/Control.Geocoder.css'
	}).appendTo('head'),
	$.getScript('https://unpkg.com/leaflet-control-geocoder/dist/Control.Geocoder.js'),//Search plugin Javascript file and css file
	$.getScript('https://ces-web2.southwales.ac.uk/students/17144159/resources/heatLayer.js'),
	$.getScript('https://ces-web2.southwales.ac.uk/students/17144159/resources/leaflet-heatLayer.js'), //Heatmap plugin Javascript file and css file
	$.getScript('https://ces-web2.southwales.ac.uk/students/17144159/resources/data/pharmacies.js'), //geoJSON dataset
	$.Deferred(function(deferred){
		$(deferred.resolve);
	})
	).done(function(){
		
		var mymap = new L.Map('map_space', {
			center: new L.LatLng(51.478, -3.182),
			zoom: 13
		});
		L.tileLayer(
				'https://api.tiles.mapbox.com/v4/{id}/{z}/{x}/{y}.png?access_token=pk.eyJ1IjoiY2hpaG9vOTkiLCJhIjoiY2s2Nmk2bmdiMTE0MjNwbDJtNmh2Nm52dCJ9.aq_mB86ZFQ2XX07FWQK1OQ',{
				maxZoom: 18,
				id:'mapbox.streets'
			}
		).addTo(mymap);


 		var cfg = {
		// radius should be small ONLY if scaleRadius is true (or small radius is intended)
		// if scaleRadius is false it will be the constant radius used in pixels
		"radius": 0.1,
		"maxOpacity": .8,
		// scales the radius based on map zoom
		"scaleRadius": true,
		// if set to false the heatmap uses the global maximum for colorization
		// if activated: uses the data maximum within the current map boundaries
		//   (there will always be a red spot with useLocalExtremas true)
		"useLocalExtrema": true,
		// which field name in your data represents the latitude - default "lat"
		latField: 'lat',
		// which field name in your data represents the longitude - default "lng"
		lngField: 'lng',
		// which field name in your data represents the data value - default "value"
		valueField: 'count'
		};

		L.Control.geocoder({
		collapsed:false
		}).addTo(mymap);

	  
	


 	geoJson2heat = function(geojson, intensity) {
	   return geojson.features.map(function(feature) {
	   return {lat:parseFloat(feature.geometry.coordinates[1]), 
			   lng:parseFloat(feature.geometry.coordinates[0]), value:intensity};
	   });
	}
		 

	var dataSet = geoJson2heat(myGeoJson , 1);
	
	var heatMap = L.heatLayer(dataSet,{ radius: 30,blur: 24, maxZoom: 13});
	mymap.addLayer(heatMap);
			
		

	
	 
	
});
});

/***********************Openlayers*************************/
/*Part 18*/
$("#part18").click(function(){
	$("#map_space").replaceWith(oldState.clone());
	
	 $("h1").html("Part 18 Openlayers Map");
	var osmLayer = new ol.layer.Tile
		({
			source: new ol.source.OSM()
		});
		var birmingham = ol.proj.transform([-1.81185, 52.44314],'EPSG:4326', 'EPSG:3857');
		var view = new ol.View
		({
			center: birmingham,
			zoom: 6
		});
		var map = new ol.Map
		({
			target: 'map_space'
		});
		map.addLayer(osmLayer);
		map.setView(view);

	
});
/*Part 19*/
$("#part19").click(function(){
	$("#map_space").replaceWith(oldState.clone());
	 $("h1").html("Part 19 Openlayers controls");
	$('<div id="overlay" style="background-color: white; border-radius:10px; border:1px solid black; padding 5px 10px;">').insertAfter("#map_space");
	var layer = new ol.layer.Tile
	({
		source: new ol.source.OSM
	});
	var interaction = new ol.interaction.DragRotateAndZoom();
	var control = new ol.control.FullScreen();
	var center = ol.proj.transform([-1.812, 52.443], 'EPSG:4326', 'EPSG:3857');
	var overlay = new ol.Overlay
	({
		position: center,
		element: document.getElementById('overlay')
	});
	var view = new ol.View
	({
		center: center,
		zoom: 6
	});
	var map = new ol.Map
	({
		target: 'map_space',
		layers: [layer],
		interactions: [interaction],
		controls: [control],
		overlays: [overlay],
		view: view
	});
});

/*Part 20*/
$("#part20").click(function(){
	$("#map_space").replaceWith(oldState.clone());
	 $("h1").html("Part 20 Openlayers click event");
	$('<div id="overlay" style="background-color: white; border-radius:10px; border:1px solid black; padding 5px 10px;">').insertAfter("#map_space");
		
			var layer = new ol.layer.Tile
			({
				source: new ol.source.OSM()
			});
			var center = ol.proj.transform([-1.812, 52.443], 'EPSG:4326', 'EPSG:3857');
			var view = new ol.View
			({
				center: center,
				zoom: 6
			});
			var map = new ol.Map
			({
				target: 'map_space',
				layers: [layer],
				view: view
			});
			
			// create overlay object
			var overlay = new ol.Overlay
			({
				element: document.getElementById('overlay'),
				positioning: 'bottom-center'
			});
			
			// create click event
			map.on('click', function(event)
			{
				var coord = event.coordinate;
				var degrees = ol.proj.transform(coord, 'EPSG:3857', 'EPSG:4326');
				var hdms = ol.coordinate.toStringHDMS(degrees);
				var element = overlay.getElement();
				element.innerHTML = hdms;
				overlay.setPosition(coord);
				map.addOverlay(overlay);
			});

	
});
/*Part 21*/
$("#part21").click(function(){
	$("#map_space").replaceWith(oldState.clone());
	 $("h1").html("Part 21 Openlayers Hide map Event");
	$("#checkboxOnOff").show();
		var osmLayer = new ol.layer.Tile
			({
				source: new ol.source.OSM()
			});
			var birmingham = ol.proj.transform([-1.81185, 52.44314],'EPSG:4326', 'EPSG:3857');
			var view = new ol.View
			({
				center: birmingham,
				zoom: 6
			});
			var map = new ol.Map
			({
				target: 'map_space'
			});
			map.addLayer(osmLayer);
			map.setView(view);

			var checkbox = document.querySelector('#layerOnOff');

			// add event listener to layerOnOff checkbox
			checkbox.addEventListener('change', function() {
			  var checked = this.checked;
			  if (checked !== osmLayer.getVisible()) {
				osmLayer.setVisible(checked);
			  }
			});
			// add event listner to osmLayer
			osmLayer.on('change:visible', function() {
			  var visible = this.getVisible();
			  if (visible !== checkbox.checked) {
				checkbox.checked = visible;
			  }
			});
});
/*Part 22*/
$("#part22").click(function(){
	$("#map_space").replaceWith(oldState.clone());
	 $("h1").html("Part 22 Openlayers Two maps");
		$("#map_space2").show();
		var london = ol.proj.transform([-0.12755, 51.507222], 'EPSG:4326', 'EPSG:3857');
	    var osmLayer = new ol.layer.Tile
		({
			source: new ol.source.OSM()
		});
     		var map = new ol.Map
		({
			layers: [
				osmLayer
			],
			target: 'map_space',
			view: new ol.View({
				center: london,
				zoom: 7
			})		
		});
		
		var map2 = new ol.Map
		({
			layers: [
				new ol.layer.Tile({
					source: new ol.source.OSM()
				})
			],
			target: 'map_space2',
			view: new ol.View({
				center: london,
				zoom: map.getView().getZoom() - 4
			})		
		});
		
		// add event listner to map view
		map.getView().on('change', function() {
			  map2.getView().setZoom(map.getView().getZoom() - 4),
			  map2.getView().setCenter(map.getView().getCenter())
		});
		
	  // add event listner to map2 view
		map2.getView().on('change', function() {
			  map.getView().setZoom(map2.getView().getZoom() + 4),
			  map.getView().setCenter(map2.getView().getCenter())
		});
});

/*Part 23*/
$("#part23").click(function(){
	$("#map_space").replaceWith(oldState.clone());
	 $("h1").html("Part 23 Openlayers Animation");
	$(".btnAnimations").show();
		var layer = new ol.layer.Tile
			({
				source: new ol.source.OSM()
			});
			var london = ol.proj.transform([-0.12755, 51.507222], 'EPSG:4326', 'EPSG:3857');
			var rome = ol.proj.transform([12.5, 41.9], 'EPSG:4326', 'EPSG:3857');
			var view = new ol.View
			({
				center: london,
				zoom: 6
			});
			var map = new ol.Map
			({
				target: 'map_space',
				layers: [layer],
				view: view
			});
			
	 $("#moves").click(function(e){
			view.animate
				({
					center: rome,
					duration: 2000
				});	
	});
				
	$("#spins").click(function(e){ 
			// Rotation animation takes the shortest arc, so animate in two parts
			var center = view.getCenter();
			view.animate
			(
				{
					center: [
					center[0] + (rome[0] - center[0]) / 2,
					center[1] + (rome[1] - center[1]) / 2
					],
					rotation: Math.PI,
					easing: ol.easing.easeIn
				}, 
				{
					center: rome,
					rotation: 2 * Math.PI,
					easing: ol.easing.easeOut
				}
			);
	}); 
	

	
});

/*Part 24*/
$("#part24").click(function(){
	$("#map_space").replaceWith(oldState.clone());
	 $("h1").html("Part 24 Openlayers Overlay");
		var london = ol.proj.transform([-0.12755, 51.507222], 'EPSG:4326', 'EPSG:3857');
	    var osmLayer = new ol.layer.Tile
		({
				source: new ol.source.OSM()
		});
		
       var map = new ol.Map
		({
			controls: ol.control.defaults().extend([
				new ol.control.OverviewMap()
			]),
			layers: [
				osmLayer 
			],
			target: 'map_space',
			view: new ol.View({
				center: london,
				zoom: 7
			})
			
		});

});
/*Part 25*/
$("#part25").click(function(){
	 $("h1").html("Part 25 Openlayers Stamen map");
	$("#map_space").replaceWith(oldState.clone());
		var stamenLayer = new ol.layer.Tile
			({
				source: new ol.source.Stamen
				({
					layer: 'watercolor'
				})
			});
			
			var map = new ol.Map
			({
				layers: [stamenLayer],
				target: 'map_space',
				view: new ol.View
				({
					center: ol.proj.transform([2.35239, 48.858391], 'EPSG:4326','EPSG:3857'),
					zoom: 12
				})
			});

});

/*Part 26*/
$("#part26").click(function(){
	$("#map_space").replaceWith(oldState.clone());
	 $("h1").html("Part 26 Openlayers bing");
		var london = ol.proj.transform([-0.12755, 51.507222], 'EPSG:4326', 'EPSG:3857');
		
			var sourceBingMaps = new ol.source.BingMaps
			({
				key: 'At6NgOUVrZrMOkB_DzLzYAdS7qpp0u4aptYAMq_yRvHHqDiDdQn4FMmL_aS3ruJl',
				imagerySet: 'Road'
			});
			var bingMapsRoad = new ol.layer.Tile
			({
				source: sourceBingMaps
			});
			
		
			var map = new ol.Map
			({
				layers: [bingMapsRoad],
				target: 'map_space',
				view: new ol.View
				({
					center: london,
					zoom: 13
				})
			});
	
});

/*Part 27*/
$("#part27").click(function(){
	$("#map_space").replaceWith(oldState.clone());
	 $("h1").html("Part 27 Openlayers WMS");
		var layers = [
        new ol.layer.Tile({
          source: new ol.source.OSM()
        }),
        new ol.layer.Image({
          extent: [-13884991, 2870341, -7455066, 6338219],
          source: new ol.source.ImageWMS({
            url: 'https://ahocevar.com/geoserver/wms',
            params: {'LAYERS': 'topp:states'},
            ratio: 1,
            serverType: 'geoserver'
          })
        })
      ];
      var map = new ol.Map({
        layers: layers,
        target: 'map_space',
        view: new ol.View({
          center: [-10997148, 4569099],
          zoom: 4
        })
      });	
});
/***********************GEOserver*************************/
/*Part 28*/
$("#part28").click(function(){
	$("#map_space").replaceWith(oldState.clone());
	 $("h1").html("Part 28 Openlayers WMS pulled data");
		var layers = [
        new ol.layer.Tile({
          source: new ol.source.OSM()
        }),
        new ol.layer.Image({
		 source: new ol.source.ImageWMS({
			  url:'http://ces-gis.usw.southwales.ac.uk:8080/geoserver/s41/wms',
			  params: {'LAYERS': 's41:dentists'},
			  ratio: 1,
			  serverType: 'geoserver'})
          })
      ];
      var map = new ol.Map({
        layers: layers,
        target: 'map_space',
        view: new ol.View({
          center: ol.proj.fromLonLat([-3.573,52.417]),
          zoom: 8
        })
      });	
	
});



/*Part 29*/
$("#part29").click(function(){
	$("#map_space").replaceWith(oldState.clone());
	 $("h1").html("Part 29 Openlayers WMS multiple layers");
		var layers = [
        new ol.layer.Tile({
          source: new ol.source.OSM()
        }),
        new ol.layer.Image({
		 source: new ol.source.ImageWMS({
			  url:'http://ces-gis.usw.southwales.ac.uk:8080/geoserver/s41/wms',
			  params: {'LAYERS': 's41:dentists,s41:aonb'}, //specified to call two wms layers
			  ratio: 1,
			  serverType: 'geoserver'})
          })
      ];

		  var map = new ol.Map({
			layers: layers,
			target: 'map_space',
			view: new ol.View({
			  center: ol.proj.fromLonLat([-3.573,52.417]),
			  zoom: 8
			})
		  });	
	
});
/*Part 30*/
$("#part30").click(function(){
	$("#map_space").replaceWith(oldState.clone());
	$("h1").html("Part 30 Openlayers Group layer WMS");
		var layers = [
        new ol.layer.Tile({
          source: new ol.source.OSM()
        }),
        new ol.layer.Image({
		 source: new ol.source.ImageWMS({
			  url:'http://ces-gis.usw.southwales.ac.uk:8080/geoserver/s41/wms',
			  params: {'LAYERS': 's41:Dentists_Aonb_Outline'}, //specified to call two wms layers
			  ratio: 1,
			  serverType: 'geoserver'})
          })
      ];

		  var map = new ol.Map({
			layers: layers,
			target: 'map_space',
			view: new ol.View({
			  center: ol.proj.fromLonLat([-3.573,52.417]),
			  zoom: 8
			})
		  });	
	
});
//Part 31
$("#part31").click(function(){
	$("#map_space").replaceWith(oldState.clone());
	$("h1").html("Part 31 Openlayers WMS PostGIS");
	
		var layers = [
        new ol.layer.Tile({
          source: new ol.source.OSM()
        }),
        new ol.layer.Image({
		 source: new ol.source.ImageWMS({
			  url:'http://ces-gis.usw.southwales.ac.uk:8080/geoserver/s41/wms',
			  params: {'LAYERS': 's41:builtupareas'}, //specified to call two wms layers
			  ratio: 1,
			  serverType: 'geoserver'})
          })
      ];

		  var map = new ol.Map({
			layers: layers,
			target: 'map_space',
			view: new ol.View({
			  center: ol.proj.fromLonLat([-3.573,52.417]),
			  zoom: 8
			})
		  });	
	
	
});
//Part 32
$("#part32").click(function(){
	$("#map_space").replaceWith(oldState.clone());
	$("h1").html("Part 32 Openlayers WMS PostGIS Own Data");
	
		var layers = [
        new ol.layer.Tile({
          source: new ol.source.OSM()
        }),
        new ol.layer.Image({
		 source: new ol.source.ImageWMS({
			  url:'http://ces-gis.usw.southwales.ac.uk:8080/geoserver/s41/wms',
			  params: {'LAYERS': 's41:Boundaries'}, //specified to call two wms layers
			  ratio: 1,
			  serverType: 'geoserver'})
          })
      ];

		  var map = new ol.Map({
			layers: layers,
			target: 'map_space',
			view: new ol.View({
			  center: ol.proj.fromLonLat([-3.573,52.417]),
			  zoom: 8
			})
		  });	
	
	
});

//Part 33
$("#part33").click(function(){
	$("#map_space").replaceWith(oldState.clone());
	$("h1").html("Part 33 Openlayers premade styles WMS");
	
		var layers = [
        new ol.layer.Tile({
          source: new ol.source.OSM()
        }),
        new ol.layer.Image({
		 source: new ol.source.ImageWMS({
			  url:'http://ces-gis.usw.southwales.ac.uk:8080/geoserver/s41/wms',
			  params: {'LAYERS': 's41:primaryschools',
			  'STYLES':'s41:trianglePoints'}, //specified to call two wms layers
			  ratio: 1,
			  serverType: 'geoserver'})
          })
      ];

		  var map = new ol.Map({
			layers: layers,
			target: 'map_space',
			view: new ol.View({
			  center: ol.proj.fromLonLat([-3.573,52.417]),
			  zoom: 8
			})
		  });	
});

//Part 34
$("#part34").click(function(){
	$("#map_space").replaceWith(oldState.clone());
	$("h1").html("Part 34 Leaflet Custom styles 1");
	
	var mymap = L.map('map_space').setView([52.417, -3.573], 13);
	
	L.tileLayer('https://api.tiles.mapbox.com/v4/{id}/{z}/{x}/{y}.png?access_token=pk.eyJ1IjoiY2hpaG9vOTkiLCJhIjoiY2s2Nmk2bmdiMTE0MjNwbDJtNmh2Nm52dCJ9.aq_mB86ZFQ2XX07FWQK1OQ',
	{
	maxZoom: 8,
	id:'mapbox.streets'
	}).addTo(mymap);
	
	L.tileLayer.wms('http://ces-gis.usw.southwales.ac.uk:8080/geoserver/s41/wms',{
		layers:'s41:aonb',
		styles:'s41:attributeBased',
		opacity:0.5,
		format:'image/png',
		transparent:true
	}).addTo(mymap)
	
});

//Part 35
$("#part35").click(function(){
	$("#map_space").replaceWith(oldState.clone());
	$("h1").html("Part 35 Leaflet Custom styles 2");
	
	var mymap = L.map('map_space').setView([52.417, -3.573], 13);
	
	L.tileLayer('https://api.tiles.mapbox.com/v4/{id}/{z}/{x}/{y}.png?access_token=pk.eyJ1IjoiY2hpaG9vOTkiLCJhIjoiY2s2Nmk2bmdiMTE0MjNwbDJtNmh2Nm52dCJ9.aq_mB86ZFQ2XX07FWQK1OQ',
	{
	maxZoom: 8,
	id:'mapbox.streets'
	}).addTo(mymap);
	
	L.tileLayer.wms('http://ces-gis.usw.southwales.ac.uk:8080/geoserver/s41/wms',{
		layers:'s41:builtupareas',
		styles:'s41:css',
		opacity:0.9,
		format:'image/png',
		transparent:true
	}).addTo(mymap)
	
	
});

//Part 36
$("#part36").click(function(){
	$("#map_space").replaceWith(oldState.clone());
	$("h1").html("Part 36 Openlayers Custom styles 3");
		var layers = [
        new ol.layer.Tile({
          source: new ol.source.OSM()
        }),
        new ol.layer.Image({
		 source: new ol.source.ImageWMS({
			  url:'http://ces-gis.usw.southwales.ac.uk:8080/geoserver/s41/wms',
			  params: {'LAYERS': 's41:outline',
			  'STYLES':'s41:attributeBased'}, //specified to call two wms layers
			  
			  ratio: 1,
			  serverType: 'geoserver'})
          })
      ];

		  var map = new ol.Map({
			layers: layers,
			target: 'map_space',
			view: new ol.View({
			  center: ol.proj.fromLonLat([-3.573,52.417]),
			  zoom: 8
			})
		  });	
});

//Part 37 WFS
$("#part37").click(function(){
	$("#map_space").replaceWith(oldState.clone());
	$("h1").html("Part 35 Leaflet WFS");
	
	mymap = L.map('map_space').setView([52.417, -3.573], 13);
	
	var titleLayer = L.tileLayer('https://api.tiles.mapbox.com/v4/{id}/{z}/{x}/{y}.png?access_token=pk.eyJ1IjoiY2hpaG9vOTkiLCJhIjoiY2s2Nmk2bmdiMTE0MjNwbDJtNmh2Nm52dCJ9.aq_mB86ZFQ2XX07FWQK1OQ',
	{
	maxZoom: 8,
	id:'mapbox.streets'
	}).addTo(mymap);
	
	var rootURL = 'http://ces-gis.usw.southwales.ac.uk:8080/geoserver/s41/ows'
	
	var WFSparameters = {
		service: 'WFS',
		version: '1.0.0',
		request: 'GetFeature',
		typeName: 's41:dentists',
		maxFeatures: 2000,
		outputFormat: 'text/javascript',
		format_options: 'callback: getJson',
		srsName: 'EPSG:4326'
	};
	
	var caseURL = rootURL + L.Util.getParamString(WFSparameters);
	$.ajax({
		url: caseURL,
		dataType: 'jsonp',
		jsonpCallback: 'getJson',
		success: handleJson
	});
	
	var style1 = {
				radius: 6,
				fillColor: "#ff6600", color: "#000",
				weight: 1, opacity: 1, fillOpacity: 0.5
			};
	var style2 =  {
		radius: 4,
		fillColor: '#000', fillOpacity: 1,
		color: '#000'
	};
	function handleJson(response){	
		WFSLayer = L.geoJSON(response, {
			pointToLayer: function(feature, latlng){
				return L.circleMarker(latlng, style2)
			},
			
		onEachFeature:function (feature, layer){
			popupOptions = {maxWidth: 300};
			var html = "";
			html += "DENTAL PRACTICE<br/>"  
			+ "Address1: " + feature.properties["address1"] + "<br/>"
			+ "Address2: " + feature.properties["address2"] + "<br/>"
			+ "Postcode: " + feature.properties["postcode"] + "<br/>";
		
			layer.bindPopup(html, popupOptions);
	}
	});
	
	mymap.addLayer(WFSLayer);
	};
	
	
});

 });

