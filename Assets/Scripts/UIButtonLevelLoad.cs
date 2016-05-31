using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class UIButtonLevelLoad : MonoBehaviour {
	
	public string LevelToLoad;
	private string LevelPrefix="Level";
	
	public void loadLevel() {


		if (LevelToLoad == "") {

			SceneManager.LoadScene ((SceneManager.GetActiveScene ().buildIndex) + 1);

		} else {
			SceneManager.LoadScene (LevelToLoad);
		}


	}

	public void ContinueLevel(){
		Debug.Log ("Loading Level: "+LevelPrefix+PlayerPrefs.GetInt("CurrentLevel"));
		SceneManager.LoadScene (LevelPrefix+PlayerPrefs.GetInt("CurrentLevel"));
	}
}
