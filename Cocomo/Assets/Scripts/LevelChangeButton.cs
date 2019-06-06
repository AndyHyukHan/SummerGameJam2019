using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelChangeButton : MonoBehaviour
{
    public void Clicked()
    {
        Debug.Log("Clicked");
    }

    public void SceneChange(string sceneName)
    {
        Debug.Log("Change scene to: " + sceneName);


    }

    public void ReloadScene()
    {
        Debug.Log("Reload scene");


    }

    public void ExitApp()
    {
        Debug.Log("Quitting application");


    }
}
