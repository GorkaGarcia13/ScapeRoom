using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endgame : MonoBehaviour {

	private bool end;

	private float myTime;
	private float wait = 3;

	void Update(){
		if (end && Time.time >= myTime + wait) {

			SceneManager.LoadScene ("You Win");
		}
	}

	void OnTriggerEnter(Collider other){
		if (other.CompareTag("Player"))
			//SceneManager.LoadScene ("You Win");
			end = true;
		myTime = Time.time;
	}
}
