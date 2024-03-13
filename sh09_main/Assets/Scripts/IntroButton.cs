using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroButton : MonoBehaviour
{
    public void introButton()
    {
        //Loads the main Scene
        SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
    }
}
