using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerLvl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	public void StartGame(){
		SceneManager.LoadScene ("Game");
	}
	public void ExitGame(){
		Application.Quit();
	}
}
