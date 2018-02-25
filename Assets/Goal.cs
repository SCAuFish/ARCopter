using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {

	LineRenderer line;

	// Use this for initialization
	void Start () {
		line = GetComponent<LineRenderer> ();
		line.SetWidth (.05f, .05f);
	}
		
	
	// Update is called once per frame
	void Update () {
		line.SetPosition (0, transform.parent.position);
		line.SetPosition (1, new Vector3 (transform.parent.position.x, 0, transform.parent.position.z));		
	}
}
