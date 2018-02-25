using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEffect : MonoBehaviour {
	public ParticleSystem fire;

	// Use this for initialization
	void Start () {
		fire.Pause ();
		//fire.Play ();
	}


	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		//Debug.Log ("method called");
		if (other != null) {
			fire.Play ();
		}
	}
}
