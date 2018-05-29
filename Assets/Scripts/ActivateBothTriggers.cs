using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateBothTriggers : MonoBehaviour {

	private bool a, b;

	public GameObject objectToActivate;

	public GameObject portal1, portal2;

	public GameObject oldPortal;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Activate1()
	{
		oldPortal.SetActive(false);
		a = true;
		if (b) AllActivated();
		else
		{
			portal1.SetActive(true);
			portal2.SetActive(false);
		}
	}

	public void Activate2()
	{
		oldPortal.SetActive(false);
		b = true;
		if (a) AllActivated();
		else
		{
			portal2.SetActive(true);
			portal1.SetActive(false);
		}
	}

	void AllActivated()
	{
		objectToActivate.SetActive(true);
		portal1.SetActive(false);
		portal2.SetActive(false);
	}
}
