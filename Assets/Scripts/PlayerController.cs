using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private CharacterController controller;
	public Transform cam;

	//private Rigidbody

	public float velocity, rotation, gravity;

	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		float z, x;

		x = Input.GetAxis("Horizontal") * velocity;
		z = Input.GetAxis("Vertical") * velocity;
		//Vector3 oldVel = 
		Vector3 mov = new Vector3(x, 0, z);
		controller.Move(transform.TransformDirection(mov));

		float v, h;

		h = Input.GetAxis("Mouse X") * rotation;
		v = Input.GetAxis("Mouse Y") * rotation;

		transform.Rotate(new Vector3(0, h, 0));
		cam.Rotate(new Vector3(-v, 0, 0));
	}
}
