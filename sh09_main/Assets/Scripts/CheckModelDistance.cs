using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckModelDistance : MonoBehaviour
{

    private GameObject Player;
    private Vector3 PlayerPosition;
    private float closeEnough;

    public GameObject button;

    // // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        closeEnough = 10;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPosition = Player.transform.position;
        // Debug.Log(PlayerPosition);

        float distance = Vector3.Distance(PlayerPosition, this.transform.position);
        // Debug.Log(distance);
        if (distance < closeEnough)
        {
            button.SetActive(true);
        }else
        {
            button.SetActive(false);
        }
    }
}
