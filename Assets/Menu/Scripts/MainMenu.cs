using UnityEngine;
using UnityEngine.SceneManagement;

namespace Menu.Scripts
{
	public class MainMenu : MonoBehaviour {


		public void OpenApp()
		{
			SceneManager.LoadScene("HelloAR", LoadSceneMode.Single);
		}
	
		public void ExitApp()
		{
			Application.Quit();
		}
	}
}
