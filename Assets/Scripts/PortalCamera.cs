using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalCamera : MonoBehaviour {

	public Transform portal, otherPortal;

	private Transform playerCamera;


	// Use this for initialization
	void Start () {
		playerCamera = GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<Camera>().transform;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		Vector3 relativePosition = otherPortal.InverseTransformPoint (playerCamera.position);

		transform.position = portal.TransformPoint (relativePosition);

		transform.rotation = portal.rotation * (Quaternion.Inverse (otherPortal.rotation) * playerCamera.rotation);
	}
}
