using UnityEngine;
using System.Collections;

public class InitializePreferences : MonoBehaviour {

	// Use this for initialization
	void Start () {
		

		if(PlayerPrefs.GetInt("CurrentLevel")<=0){
			Debug.Log ("First Time Use");
			initializePreferences (); 
		}

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void DeletePreferences(){
		Debug.Log ("Deleting PlayerPrefs");
		PlayerPrefs.DeleteAll();

	}
	public void initializePreferences(){
		
		PlayerPrefs.SetInt ("CurrentLevel", 1);
		PlayerPrefs.SetInt ("TargetFPS",30);
		Debug.Log (PlayerPrefs.GetInt("CurrentLevel"));
	}
}
