using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mapbox.Examples;
using Mapbox.Utils;

public class EventPointer : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 50f;
    [SerializeField] float amplitude = 2.0f;
    [SerializeField] float frequency = 0.50f;


    LocationStatus playerLocation;
    public Vector2d eventPose;
    // Start is called before the first frame update
    void Start()
    {
        playerLocation = GameObject.FindObjectOfType<LocationStatus>();
        
        if (playerLocation == null)
        {
            Debug.LogError("Player location not found");
        }
    }

    // Update is called once per frame
    void Update()
    {
        RotateAndFloatPointer();
    }

    
    void RotateAndFloatPointer()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, (Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude) * 15, transform.position.z);
    }

    void OnMouseDown()
    {
        playerLocation = GameObject.Find("Canvas").GetComponent<LocationStatus>();

        if (playerLocation!=null){
            var currentPlayerLocation = new GeoCoordinatePortable.GeoCoordinate(playerLocation.GetLocationLat(), playerLocation.GetLocationLon());
            var eventLocation = new GeoCoordinatePortable.GeoCoordinate(eventPose[0], eventPose[1]);
            var distance = currentPlayerLocation.GetDistanceTo(eventLocation);
            Debug.Log("Distance is: " + distance);
        }
        else{
            Debug.LogError("Player location not found");
        }
    }
}
