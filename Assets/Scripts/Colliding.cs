using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Colliding : MonoBehaviour {

	public PlayerController movement;

	void OnCollisionEnter(Collision collisionInfo )
	{
		if (collisionInfo.collider.tag == "obstacle") {
			movement.enabled = false;
			FindObjectOfType<GameManager>().GameOver ();
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
