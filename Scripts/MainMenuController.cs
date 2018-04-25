using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour {

	public GameObject cursorUp;
	public GameObject cursorDown;
	public GameObject cursorAttack;

	AudioSource enemyHurt;
	AudioSource meleePlayer;

	public bool selection = true;

	// Use this for initialization
	void Start () {

		AudioSource[] audios = GetComponents<AudioSource> ();
		enemyHurt = audios [0];
		meleePlayer = audios [1];

		cursorUp.SetActive(true);
		cursorDown.SetActive(false);
		cursorAttack.SetActive(false);
	}

	void Update()
	{
			HandleInput();	
	}

	private void HandleInput()
	{
		if (Input.GetKeyDown (KeyCode.W) || Input.GetKeyDown (KeyCode.UpArrow)) {
			cursorUp.SetActive(true);
			cursorDown.SetActive(false);

			enemyHurt.Play ();
		}
		if (Input.GetKeyDown (KeyCode.S) || Input.GetKeyDown (KeyCode.DownArrow)) {
			cursorUp.SetActive(false);
			cursorDown.SetActive(true);
			AudioSource audio = GetComponent<AudioSource> ();
			enemyHurt.Play ();
		}

		if(Input.GetKeyDown (KeyCode.Z) && GameObject.Find("cursorUp") != null && GameObject.Find("cursorDown") == null) {
			cursorUp.SetActive(false);
			cursorAttack.SetActive(true);

			meleePlayer.Play ();
		}

		if(Input.GetKeyDown (KeyCode.Z) && GameObject.Find("cursorUp") == null && GameObject.Find("cursorDown") != null) {
			Application.Quit();
		}
	}
		
}
