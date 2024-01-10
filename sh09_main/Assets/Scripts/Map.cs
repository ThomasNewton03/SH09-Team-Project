using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System;

public class Map : MonoBehaviour
{
    public string accessToken;
    public float centerLatitude = 55.8727f;
    public float centerLongitude = -4.2927f;
    public float zoom = 15.0f;
    public int bearing = 0;
    public int pitch = 0;
    public enum style { Light, Dark, Streets, Outdoors, Satellite, SatelliteStreets };
    public style mapStyle = style.Streets;
    public enum resolution { low = 1, high = 2 };
    public resolution mapResolution = resolution.low;
    public double[] boundingBox = new double[] { 151.196023022085, -33.8777251205232, 151.216012372138, -33.8683894791246 }; //[lon(min), lat(min), lon(max), lat(max)]

    private int mapWidth = 800;
    private int mapHeight = 600;
    private string[] styleStr = new string[] { "light-v10", "dark-v10", "streets-v11", "outdoors-v11", "satellite-v9", "satellite-streets-v11" };
    private string url = "";
    private bool mapIsLoading;
    private bool updateMap = true;
    public Rect rect;

    private string accessTokenLast;
    public float centerLatitudeLast = 55.8727f;
    public float centerLongitudeLast = -4.2927f;
    private float zoomLast = 15.0f;
    private int bearingLast = 0;
    private int pitchLast = 0;
    private style mapStyleLast = style.Streets;
    private resolution mapResolutionLast = resolution.low;




    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GetMap());
        rect = gameObject.GetComponent<RawImage>().rectTransform.rect;
        mapHeight = (int)Math.Round(rect.height);
        mapWidth = (int)Math.Round(rect.width);
    }

    // Update is called once per frame void Update(){ }

    void Update()
    {
        if (updateMap && (accessTokenLast!=accessToken || !Mathf.Approximately(centerLatitudeLast, centerLatitude) || !Mathf.Approximately(centerLongitudeLast, centerLongitude) || zoomLast!=zoom || bearingLast!=bearing || pitchLast!=pitch || mapStyleLast!=mapStyle || mapResolutionLast!=mapResolution)){
            rect = gameObject.GetComponent<RawImage>().rectTransform.rect;
            mapWidth = (int)Math.Round(rect.width);
            mapHeight = (int)Math.Round(rect.height);
            StartCoroutine(GetMap());
            updateMap = false;
        }
    }

    IEnumerator GetMap()
    {
        url = "https://api.mapbox.com/styles/v1/mapbox/" + styleStr[(int)mapStyle] + "/static/" + centerLongitude + "," + centerLatitude + "," + zoom + "," + bearing + "," + pitch + "/" + mapWidth + "x" + mapHeight + "?" + "access_token=" + accessToken;
        //mapIsLoading = true;
        UnityWebRequest www = UnityWebRequestTexture.GetTexture(url);
        yield return www.SendWebRequest();
        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log("WWW ERROR: " + www.error);
        }
        else
        {
            mapIsLoading = false;
            gameObject.GetComponent<RawImage>().texture = ((DownloadHandlerTexture)www.downloadHandler).texture;
            accessTokenLast = accessToken;
            centerLatitudeLast = centerLatitude;
            centerLongitudeLast = centerLongitude;
            zoomLast = zoom;
            bearingLast = bearing;
            pitchLast = pitch;
            mapStyleLast = mapStyle;
            mapResolutionLast = mapResolution;
            updateMap = true;
        }
    }


}