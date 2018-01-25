using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

	public void LoadLevel(string levelName)
	{
		Debug.Log("Load level requested for: " + levelName);
		SceneManager.LoadScene(levelName);
	}

	public void RequestQuit()
	{
		Debug.Log("Quit requested");
		Application.Quit();
	}

	public void PlayerWin ()
	{
		SceneManager.LoadScene("PlayerWin");
	}

	public void PlayerLose ()
	{
		SceneManager.LoadScene("PlayerLose");
	}

}
