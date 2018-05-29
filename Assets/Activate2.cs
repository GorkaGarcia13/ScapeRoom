using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate2 : MonoBehaviour {

	public ActivateBothTriggers reciver;

	private void OnTriggerEnter(Collider other)
	{
		other.CompareTag("Player");
		reciver.Activate2();
	}
}
