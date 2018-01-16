using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public void LoadLevel(string levelName)
    {
        Debug.Log("Load level requested for: " + levelName);
    }

    public void RequestQuit()
    {
        Debug.Log("Quit requested");
    }
    
}
