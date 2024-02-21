using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour {
    public static MainManager Instance;
    public GameObject settingsObject;
    Settings settings;
    // public int fontSize;

    private void Awake() 
    {
        settings = settingsObject.GetComponent<Settings>();
        if (Instance != null) {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        //DontDestroyOnLoad(gameObject);

        LoadSettings();
    } 

    [System.Serializable]
    class SaveData
    {
        public int fontSize;
    }

    public void SaveSettings()
    {
        // SaveData data = new SaveData();
        // data.fontSize = fontSize;

        // string json = JsonUtility.ToJson(data);
    
        // File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
        settings.saveButtonSize(settings.getButtonSize());
        settings.saveFontSize(settings.getFontSize());
        settings.saveIsLeftHanded(settings.getIsLeftHanded() ? 1 : 0);
    }

    public void LoadSettings()
    {
        // string path = Application.persistentDataPath + "/savefile.json";
        // if (File.Exists(path))
        // {
        //     string json = File.ReadAllText(path);
        //     SaveData data = JsonUtility.FromJson<SaveData>(json);

        //     fontSize = data.fontSize;
        // }
        settings.loadButtonSize();
        settings.loadFontSize();
        settings.loadIsLeftHanded();
    }
    public void LoadMapScene()
    {
        SaveSettings();
        SceneManager.LoadScene("Location-basedGame", LoadSceneMode.Single);
    }

    public void LoadAppScene()
    {
        SceneManager.LoadScene("scene1", LoadSceneMode.Single);
        LoadSettings();
    }

}
