using UnityEngine;
using System.Collections;

public class ActivateOnPreference : MonoBehaviour {


	// Use this for initialization
	void Start () {

		if(PlayerPrefs.GetInt("CurrentLevel")<=1){
			this.gameObject.SetActive (false);
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
