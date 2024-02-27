using Mapbox.Unity.Location;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mapbox.Utils;

public class PlayerLocationProximity : DeviceLocationProvider
{
    public Vector2d pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos = _currentLocation.LatitudeLongitude;
        Debug.Log(pos);
    }
}
