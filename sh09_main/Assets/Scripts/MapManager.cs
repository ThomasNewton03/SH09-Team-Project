using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapManager : MonoBehaviour
{
    public void LoadAppScene()
    {
        SceneManager.LoadScene("scene1", LoadSceneMode.Single);
    }
}
