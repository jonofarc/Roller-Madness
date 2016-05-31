using UnityEngine;
using System.Collections;

public class GameFlowControll : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
		QualitySettings.vSyncCount = 0;  // VSync must be disabled
		NormalSpeed();

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void PauseSpeed () {
		Time.timeScale = 0.0F;

		AdjustFPS (15);

	}
	void NormalSpeed () {
		Time.timeScale = 1.0F;
		AdjustFPS (PlayerPrefs.GetInt("TargetFPS"));

	}

	public void TooglePause(){ 
		
		if (Time.timeScale <= 0.1f) {
			NormalSpeed ();
		} else {
			PauseSpeed ();
		}
	}
	public void AdjustFPS(int fps){

		Application.targetFrameRate = fps;
	}

}
