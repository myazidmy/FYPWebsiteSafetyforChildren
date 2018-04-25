using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour {

	public GameObject dBox; 



	// Use this for initialization
	void Start () {
		dBox.SetActive(false);

	}



	void OnTriggerEnter2D(Collider2D other){

		if (other.tag == "Player") {

			dBox.SetActive (true);
		}

	}


	void OnTriggerExit2D(Collider2D other){

		if (other.tag == "Player") {

			dBox.SetActive (false);
		}
	}
}
