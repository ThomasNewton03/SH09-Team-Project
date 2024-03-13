using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Zoom : MonoBehaviour
{
    private Camera cam;

    private void Start()
    {
        cam = GetComponent<Camera>();
    }
    public void ZoomSlider(float value)
    {
        value = Math.Abs(value);
        cam.transform.position = new Vector3(cam.transform.position.x, value, (value * (float) -0.587));
    }
}
