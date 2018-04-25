using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageAdvice : MonoBehaviour {

	public GameObject imageAdvice1;
	public GameObject imageAdvice2;
	public GameObject imageAdvice3;
	public GameObject imageAdvice4;

	// Use this for initialization
	void Start () {
		imageAdvice1.SetActive(false);
		imageAdvice2.SetActive(false);
		imageAdvice3.SetActive(false);
		imageAdvice4.SetActive(false);

		 
	}
	

	public void ImageAppear() {

		if (GameObject.Find("Boy1") == null ){
			imageAdvice1.SetActive(true);
		}

	}
}
