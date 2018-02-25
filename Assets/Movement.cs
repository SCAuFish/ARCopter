using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	//Instant variables
	public GameObject markerGoal;
	Vector3 parentPos;
	UnityEngine.AI.NavMeshAgent agent;
	SpriteRenderer destSprite;

	// Use this for initialization
	void Start () {
		agent = GetComponent<UnityEngine.AI.NavMeshAgent> ();
		destSprite = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		MoveToTarget ();
		PitchCtrl ();
	}

	void MoveToTarget(){
		if (markerGoal.active) {
			
			parentPos = markerGoal.transform.parent.position;
			agent.SetDestination (parentPos);
			destSprite.transform.position = new Vector3 (parentPos.x, 0, parentPos.z);
		}
	}

	float MapRange(float s, float a1, float a2, float b1, float b2)
	{
		if (s >= a2)
			return b2;
		if (s <= a1)
			return b1;
		return b1 + (s - a1) * (b2 - b1) / (a2 - a1);

	}
    
	void PitchCtrl(){
		transform.GetChild (0).localEulerAngles = new Vector3 (
			MapRange (agent.velocity.magnitude, 0f, 2f, 0f, 20f),
			transform.eulerAngles.y,
			transform.eulerAngles.z
		);
	}

}
