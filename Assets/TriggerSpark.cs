using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSpark : MonoBehaviour {

	public ParticleSystem fire;
	public bool isPlaying;
	// Use this for initialization
	void Start () {
		fire.Pause ();
	}
	
	// Update is called once per frame
	void Update () {
		if (isAbove () && !isPlaying) {
			fire.Play ();
			isPlaying = true;
		}
		if (!isAbove ()) {
			fire.Pause ();
			fire.Clear ();
			isPlaying = false;
		}

	}

	bool isAbove(){
		Vector3 position = this.transform.localPosition;
		if ((position.x > -0.7 && position.x < 0.7) &&
		    (position.z > -0.7 && position.z < 0.7)) {
			return true;
		} else {
			return false;
		}
	}
}
