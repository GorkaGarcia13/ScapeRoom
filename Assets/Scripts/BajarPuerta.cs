using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BajarPuerta : MonoBehaviour {

	public GameObject puerta;
	public GameObject portal1;
	public GameObject portal2;

	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other)
	{
		puerta.transform.Translate(Vector3.down * Time.deltaTime * 200);
		portal1.SetActive(false);
		portal2.SetActive(true);
		Destroy(this);
	}
}
