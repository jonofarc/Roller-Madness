using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RetryLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void ReloadLevel(){
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
	}
}
