using UnityEngine;
using System.Collections;

public class PaddleController : MonoBehaviour {

	public float PaddleSpeed;

	private Vector3 playerPosition;

	// Use this for initialization
	void Start () {
		PaddleSpeed = 0.4f;
		playerPosition = new Vector3 (0, -4.5f, 0);
	}
	
	// Update is called once per frame
	void Update () {
		UpdatePaddlePosition ();
	}

	private void UpdatePaddlePosition(){

		var xPosition = transform.position.x + (Input.GetAxis ("Tap-Horizontal") * PaddleSpeed * -1);

		playerPosition = new Vector3 (Mathf.Clamp (xPosition, -7f, 7f), -4f, -3.5f);
		transform.position = playerPosition;
	}

}
