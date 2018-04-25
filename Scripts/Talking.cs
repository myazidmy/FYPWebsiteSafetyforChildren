using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talking : MonoBehaviour {

	public GameObject textOne;
	public GameObject textTwo;

	// Use this for initialization
	void Start () {
		textOne.SetActive (true);
		textTwo.SetActive (false);
	}
	
	public void showTextTwo(){
		textOne.SetActive (false);
		textTwo.SetActive (true);
	}

	public void returnMainMenu(){
		Application.LoadLevel ("Main Menu");
	}
}
