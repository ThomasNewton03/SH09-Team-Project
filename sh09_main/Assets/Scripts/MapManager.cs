using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapManager : MonoBehaviour
{
    public void LoadAppScene()
    {
        //Load the main scene
        SceneManager.LoadScene("scene1", LoadSceneMode.Single);
    }
}
