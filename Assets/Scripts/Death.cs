using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter () {
		GameManager.Instance.LoseLife ();
	}
}
