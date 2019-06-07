using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChangeButton : MonoBehaviour
{
    public void Clicked()
    {
        Debug.Log("Clicked");
    }

    public void SceneChange(string sceneName)
    {
        Debug.Log("Change scene to: " + sceneName);

		SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
	}

    public void ReloadScene()
    {
		string reloadedScene = SceneManager.GetActiveScene().name;

        Debug.Log("Reload scene");

		SceneManager.LoadScene(reloadedScene, LoadSceneMode.Single);
    }

    public void ExitApp()
    {
        Debug.Log("Quitting application");

		Application.Quit();
    }
}
