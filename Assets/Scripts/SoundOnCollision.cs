using UnityEngine;
using System.Collections;

public class SoundOnCollision : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision coll) {
		
		if (coll.gameObject.tag=="Player") {
			GetComponent<AudioSource>().Play();
		}


	}
}
