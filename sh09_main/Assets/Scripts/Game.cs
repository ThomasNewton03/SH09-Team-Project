using UnityEngine;
public class Game : MonoBehaviour{
    public void Start(){
        GameObject obj = GameObject.Find("Settings");
        Debug.Log(obj.name);
        // obj.GetComponent<Settings>();
        
    }

    public Game(){
    }


}
