using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventPointer : MonoBehaviour
{
    [SerializeField] float amplitude = 2.0f;
    [SerializeField] float frequency = 0.50f;
    [SerializeField] float rotateSpeed = 50f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void rotateFloatPointer()
    {
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
        transform.position = new Vector3();
    }
}
