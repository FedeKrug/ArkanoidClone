using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour
{
   public void LoadScene(string sceneName)
	{
		SceneManager.LoadScene(sceneName);
	}
	public void ReloadScene()
	{
		var activeScene = SceneManager.GetActiveScene().name.ToString();
		SceneManager.LoadScene(activeScene);
	}

	public void ExitGame()
	{
		Application.Quit();
		Debug.Log("Game Exit");
#if UNITY_EDITOR
		//TODO: Quit the game in the editor
#endif
	}
}
