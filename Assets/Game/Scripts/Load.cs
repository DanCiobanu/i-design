using UnityEngine;
using UnityEngine.SceneManagement;

namespace Menu.Scripts.GameScripts
{
	public class Load : MonoBehaviour
	{
		private int sceneIndex;
		
		// Use this for initialization
		void Start ()
		{
			Screen.orientation = ScreenOrientation.Landscape;
			sceneIndex = SceneManager.GetActiveScene().buildIndex;
		}
	
		// Update is called once per frame
		void Update () {
			if (Application.platform == RuntimePlatform.Android)
			{
				if (Input.GetKey(KeyCode.Escape))
				{
					SceneManager.LoadScene(sceneIndex - 1);
				}
			}
		}
	}
}
