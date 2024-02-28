using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckModelDistance : MonoBehaviour
{

    private Vector3 PlayerPosition;
    private float closeEnough;

    // // Start is called before the first frame update
    void Start()
    {
        PlayerPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
        closeEnough = 50;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(PlayerPosition, this.transform.position);
        if (distance < closeEnough)
        {
            // button.SetActive(true);
        }else
        {
            // button.SetActive(false);
        }
    }
}
