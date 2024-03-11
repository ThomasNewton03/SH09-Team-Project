using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using Mapbox.Unity.Location;
using Mapbox.Utils;

public class CheckBoundary : AbstractLocationProvider {

    //user location is assumed to be at a Gundam model
    public Vector2d userLocation;
    public Settings settings;
    public GameObject popup;

    void Start(){

        OnLocationUpdated += OnLocationUpdatedHandler;

    }



    void OnLocationUpdatedHandler(Location location){
        //checks the distance of the coordinates and ensures the user is within range
		float maxDistance = 0.00030f;
        userLocation = location.LatitudeLongitude;

        float distanceFromGundam = (float)Vector2d.Distance(userLocation, _currentLocation.LatitudeLongitude);

		if (distanceFromGundam > maxDistance){
			settings.swapToInventoryPage();
            popup.SetActive(true);
		}
    }

}