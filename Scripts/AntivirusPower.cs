using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntivirusPower : MonoBehaviour {

	public GameObject antiVirus; 

	void Start () {
		antiVirus.SetActive(true);

	}

	void OnTriggerEnter2D(Collider2D other){
			
		if (other.tag == "Player") {

			antiVirus.SetActive (false);

			AudioSource audio = GetComponent<AudioSource> ();
			audio.Play ();

		}

	}
}
