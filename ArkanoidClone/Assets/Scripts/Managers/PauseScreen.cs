using UnityEngine;

namespace Game.Managers
{
	public class PauseScreen : MonoBehaviour
	{
		[SerializeField] private bool _paused;


		private void Update()
		{
			if (_paused)
			{
				PauseGame();
			}
			else
			{
				ResumeGame();
			}
		}

		public void PauseGame()
		{
			Time.timeScale = 0;
		}

		public void ResumeGame()
		{
			Time.timeScale = 1;
		}

	}
}
