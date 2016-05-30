using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class UIButtonLevelLoad : MonoBehaviour {
	
	public string LevelToLoad;
	
	public void loadLevel() {


		if (LevelToLoad == "") {

			SceneManager.LoadScene ((SceneManager.GetActiveScene ().buildIndex) + 1);

		} else {
			SceneManager.LoadScene (LevelToLoad);
		}


	}
}
