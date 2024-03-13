// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;
// using UnityEditor;
// using Mapbox.Unity.Location;
// using Mapbox.Utils;

// public class CheckBoundary : AbstractLocationProvider {

//     //user location is assumed to be at a Gundam model
//     public Settings settings;
//     public Vector2d userLocation;
//     public GameObject popup;

//     void Start(){

//         OnLocationUpdated += OnLocationUpdatedHandler;

//     }


//     void OnLocationUpdatedHandler(Location location){
//         //checks the distance of the coordinates and ensures the user is within range
// 		float maxDistance = 0.00030f;
//         userLocation = location.LatitudeLongitude;

//         //calculate the distance from the user to the gundam
//         float distanceFromGundam = (float)Vector2d.Distance(userLocation, _currentLocation.LatitudeLongitude);

// 		if (distanceFromGundam > maxDistance){
// 			settings.swapToInventoryPage();
//             popup.SetActive(true);
// 		}
//     }

    
    // void OnEnable(){
    //     if (!Input.location.isEnabledByUser){
    //         Debug.Log("Location not enabled on device or app does not have permission to access location");
    //         return;
    //     }
        
    //     Input.location.Start();

    //     userLocation = new Vector2d(Input.location.lastData.latitude, Input.location.lastData.longitude);
    // }



    // void Update(){
    //     //checks the distance of the coordinates and ensures the user is within range

	// 	float maxDistance = 0.00030f;

    //     public Vector2d _currentLocation = new Vector2d(Input.location.lastData.latitude, Input.location.lastData.longitude);

    //     float distanceFromGundam = (float)Vector2d.Distance(userLocation, _currentLocation.LatitudeLongitude);

	// 	if (distanceFromGundam > maxDistance){
	// 		settings.swapToInventoryPage();
    //         popup.SetActive(true);
	// 	}

    //     Debug.Log(distanceFromGundam);
    // }

// }