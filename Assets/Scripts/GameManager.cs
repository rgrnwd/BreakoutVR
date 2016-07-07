using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	public int Lives = 3;
	public int Bricks = 16;
	public float ResetDelay = 1f;
	public Text LivesText;
	public GameObject GameOver;
	public GameObject YouWin;
	public GameObject BricksPrefab;
	public GameObject Paddle;
	public GameObject DeathParticles;
	public static GameManager Instance = null;

	private GameObject clonePaddle;

	// Use this for initialization
	void Start () {
		if (Instance == null) {
			Instance = this;
		} else if (Instance != this) {
			Destroy (gameObject);
		}

		Setup ();
	}

	public void Setup(){
		SetupPaddle ();
		Instantiate (BricksPrefab, new Vector3(-6.15716f,-0.6231744f,-3.194481f), Quaternion.identity);
	}

	public void CheckGameOver(){
	
		if (Bricks < 1) {
			YouWin.SetActive (true);
			Time.timeScale = .25f;
			Invoke ("Reset", ResetDelay);
		} else if (Lives < 1) {
			GameOver.SetActive (true);
			Time.timeScale = .25f;
			Invoke ("Reset", ResetDelay);
		}
	}

	public void LoseLife(){
		Lives--;
		LivesText.text = "Lives: " + Lives;
		Instantiate (DeathParticles, clonePaddle.transform.position, Quaternion.identity);
		Destroy (clonePaddle);
		Invoke ("SetupPaddle", ResetDelay);
		CheckGameOver ();
	}

	void SetupPaddle(){
		clonePaddle = Instantiate (Paddle, new Vector3(0,-4,-3.5f), Quaternion.identity) as GameObject;

	}
	public void DestroyBrick(){
		Bricks--;
		CheckGameOver ();
	}

	void Reset(){
		Time.timeScale = 1;
		Application.LoadLevel (Application.loadedLevel);
	}

}
