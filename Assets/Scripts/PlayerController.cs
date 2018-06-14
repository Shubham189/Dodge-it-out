using System.Linq;
using UnityEngine;
using System.Threading;

 
public class PlayerController : MonoBehaviour {

	public Rigidbody rb;

	public float forwardForce = 500f;
	float forwardForceOffest = 200f;
	public float sideForce = 500f;


	// Use this for initialization
	void Start () 
	{
		//rb.useGravity = true;

		Debug.Log ("Hello World!!");
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		//rb.AddForce (0, 0, forwardForce*Time.deltaTime);
		//rb.AddForce (-1 * Random.Range (-100, 100), -1 * Random.Range (-100, 100), -1 * Random.Range (-100, 100));
		forwardForceOffest = forwardForce - 200;

		rb.AddForce (0,0,forwardForceOffest*Time.deltaTime);
		if (Input.GetKey("s"))
		{
			rb.AddForce (0, 0, -forwardForce * Time.deltaTime);
		}
		if (Input.GetKey("w"))
		{
			rb.AddForce (0, 0, forwardForce * Time.deltaTime);
		}
		if (Input.GetKey("a"))
		{
			rb.AddForce (-sideForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
		}
		if (Input.GetKey("d"))
		{
			rb.AddForce (sideForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
		}

		if (rb.position.y < -1f) {
			FindObjectOfType<GameManager> ().GameOver ();
		
		}
	}
}
