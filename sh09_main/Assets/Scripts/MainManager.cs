using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class MainManager : MonoBehaviour {
    public static MainManager Instance;

    public int fontSize;

    private void Awake() 
    {
        if (Instance != null) {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);

        LoadSettings();
    } 

    [System.Serializable]
    class SaveData
    {
        public int fontSize;
    }

    public void SaveSettings()
    {
        SaveData data = new SaveData();
        data.fontSize = fontSize;

        string json = JsonUtility.ToJson(data);
    
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadSettings()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            fontSize = data.fontSize;
        }
    }

    
}
