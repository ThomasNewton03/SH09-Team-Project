using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class CheckModelDistance : MonoBehaviour
{

    private GameObject Player;
    private Vector3 PlayerPosition;
    private float closeEnough;
    public GameObject button;

    public MapManager mapManager;

    // // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        closeEnough = 20;
        button.GetComponent<Button>().onClick.AddListener(delegate () { this.ButtonClicked(); });
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

    void ButtonClicked()
    {
        PlayerPrefs.SetString("LastActivePage", "ar");
        string name = this.name.Replace("(Clone)", "");
        Debug.Log(name);
        PlayerPrefs.SetString("TargetModel", name);
        mapManager.LoadAppScene();
    }
}
