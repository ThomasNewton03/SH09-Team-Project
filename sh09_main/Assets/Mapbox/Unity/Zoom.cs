using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    private Camera cam;

    private void Start()
    {
        cam = GetComponent<Camera>();
    }
    public void ZoomSlider(float value)
    {
        cam.transform.position = new Vector3(cam.transform.position.x, value, (value * (float) -0.587));
    }
}
