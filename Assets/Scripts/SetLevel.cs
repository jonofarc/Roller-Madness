using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SetLevel : MonoBehaviour {
	//public int CurrentLevel = 0;
	// Use this for initialization
	void Start () {
	//	PlayerPrefs.SetInt ("CurrentLevel", CurrentLevel);
		PlayerPrefs.SetInt ("CurrentLevel", (SceneManager.GetActiveScene().buildIndex)-1);
	
	}
	 
	// Update is called once per frame
	void Update () {
	
	}
}
