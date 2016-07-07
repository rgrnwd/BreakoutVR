using UnityEngine;
using System.Collections;

public class BricksController : MonoBehaviour {

	public GameObject BrickParticle;

	// Use this for initialization
	void OnCollisionEnter (Collision other) {
	
		Instantiate (BrickParticle, transform.position, Quaternion.identity);
		GameManager.Instance.DestroyBrick ();
		Destroy (gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
