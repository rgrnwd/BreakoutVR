using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

	public float BallInitialVelocity = 600f;

	private Rigidbody rigidBody;
	private bool isBallInPlay = false;

	// Use this for initialization
	void Awake () {
		rigidBody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		if ((Input.GetButtonDown("Fire1") || Input.GetButtonDown("Tap")) && !isBallInPlay){
			transform.parent = null;
			isBallInPlay = true;
			rigidBody.isKinematic = false;
			rigidBody.AddForce (new Vector3 (BallInitialVelocity, BallInitialVelocity, 0f));
		}
	}
}
