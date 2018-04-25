using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public GameObject flag;

	public int level;

	public void LoadScene (string name){
        Application.LoadLevel(name);
        
    }

	public void introOne (){
		Application.LoadLevel("Intro 1");

	}

	public void introTwo (){
		Application.LoadLevel("Level 2");

	}

	public void introThree (){
		Application.LoadLevel("Level 3");

	}

	public void Leveltwo (){
		Application.LoadLevel("Level 1");

	}
    
    public void QuitGame(){
        Application.Quit();
    }

	void OnTriggerEnter2D(Collider2D other){

		if (other.tag == "Player") {

			if (level == 1) {
				Application.LoadLevel ("Intro 2");

			}

			if (level == 2) {
				Application.LoadLevel ("Intro 3");

			}
		}

	}


}
