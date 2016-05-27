using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControlChange : MonoBehaviour {
	public bool Gyroscope=true;
	public GameObject ControlType1;
	public GameObject ControlType2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void ToogleControls(){
	
		Gyroscope = !Gyroscope;
		if (Gyroscope) {
			this.gameObject.GetComponent<Text> ().text = "Giroscopio";
			ControlType2.SetActive (false);
			ControlType1.SetActive (true);

		} else {
			this.gameObject.GetComponent<Text> ().text = "Joystick";
			ControlType1.SetActive (false);
			ControlType2.SetActive (true);
		}
	
	}
}
