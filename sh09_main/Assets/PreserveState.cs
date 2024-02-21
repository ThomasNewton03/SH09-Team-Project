using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreserveState : MonoBehaviour
{
    public static PreserveState Instance;
    private void Awake()
    {
        if (Instance != null) {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
