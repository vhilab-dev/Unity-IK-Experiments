using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBehavior : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision){
		GameObject clown = transform.parent.gameObject;
		Animator clownAnimator = clown.GetComponent<Animator> ();
		clownAnimator.SetTrigger ("hit");

	}
}
