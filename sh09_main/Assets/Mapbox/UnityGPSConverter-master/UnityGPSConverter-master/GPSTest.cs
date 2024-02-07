using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GPSTest : MonoBehaviour
{
    public Vector2 GPSPosition = new Vector2(55.8714596f, -4.2884833f);
    internal Vector3 pos;
    public GameObject userIcon;

    void Start()
    {
        pos = GPSEncoder.GPSToUCS(GPSPosition);
        print("pos: " + pos);
        print("GPS: " + GPSEncoder.USCToGPS(pos));

        if (userIcon==null){
            Debug.LogWarning("Game object not attached to userIcon");
        }
        else {
            if (userIcon.activeSelf){
                userIcon.transform.position = pos;
            }
            else {
                Instantiate(userIcon, pos, Quaternion.identity);
            }
        }
    }
    
}
