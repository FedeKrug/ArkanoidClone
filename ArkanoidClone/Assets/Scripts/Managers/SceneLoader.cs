using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;


namespace Game.Managers
{
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
		}
	}
}
