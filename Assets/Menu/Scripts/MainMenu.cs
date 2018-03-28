using UnityEngine;
using UnityEngine.SceneManagement;

namespace Menu.Scripts
{
	public class MainMenu : MonoBehaviour {


		public void OpenApp()
		{
			SceneManager.LoadScene("Game", LoadSceneMode.Single);
		}
	
		public void ExitApp()
		{
			Application.Quit();
		}
	}
}
