using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GPSLocation : MonoBehaviour{
    public Text GPSStatus;
    public Text latitudeValue;
    public Text longitudeValue;
    public Text altitudeValue;
    public Text horizontalAccuracyValue;
    public Text timeStampValue;
    void Start(){
        StartCoroutine(GPSLoc());
    }

    IEnumerator GPSLoc(){
        if (!Input.location.isEnabledByUser)
            yield break;
        Input.location.Start();

        int maxWait = 20;
        while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0){
            yield return new WaitForSeconds(1);
            maxWait--;
        }

        if (maxWait < 1){
            GPSStatus.text = "Time out";
            yield break;
        }

        if (Input.location.status == LocationServiceStatus.Failed){
            GPSStatus.text = "Unable to determine device location";
            yield break;
        }
        else{
            GPSStatus.text = "Running";
            InvokeRepeating("UpdateGPSData", 0.5f, 1f);
        }
    }

    private void UpdateGPSData(){
        if (Input.location.status == LocationServiceStatus.Running){
            GPSStatus.text = "Running";
            latitudeValue.text = Input.location.lastData.latitude.ToString();
            longitudeValue.text = Input.location.lastData.longitude.ToString();
            altitudeValue.text = Input.location.lastData.altitude.ToString();
            horizontalAccuracyValue.text = Input.location.lastData.horizontalAccuracyValue.ToString();
            timeStampValue.text = Input.location.lastData.timeStampValue.ToString();
        }
        else{
            GPSStatus.text = "Stop";
        }
    }

}
