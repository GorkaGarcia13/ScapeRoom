using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouWin : MonoBehaviour {

	private float myTime;
	public float wait;

	// Use this for initialization
	void Start () {
		myTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {

		if (Time.time >= myTime + wait) {
		
			SceneManager.LoadScene ("MainMenu");
		}
		
	}
}
