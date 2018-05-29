using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private CharacterController controller;
	private Transform cam;

	private Rigidbody body;

	public float velocity, jump, rotation, maxFloorSlope;

	private bool canJump = true;

	private AudioSource mAudio;

	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController>();
		body = GetComponent<Rigidbody> ();
		cam = transform.GetChild (0);
		Cursor.lockState = CursorLockMode.Locked;
		mAudio = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		float z, x, y;

		Vector3 oldVel = body.velocity;

		x = Input.GetAxis("Horizontal") * velocity * Time.deltaTime;
		z = Input.GetAxis("Vertical") * velocity * Time.deltaTime;
		y = oldVel.y;


		if (Input.GetKeyDown ("space") && canJump) {
			//body.AddForce (Vector3.up * jump, ForceMode.Impulse);
			canJump = false;
			y = jump;
		}
		//Vector3 oldVel = 
		Vector3 mov = new Vector3(x, y, z);
		//controller.SimpleMove(transform.TransformDirection(mov * velocity));
		//controller.Move

		body.velocity = transform.TransformDirection(mov);

		float v, h;

		h = Input.GetAxis("Mouse X") * rotation;
		v = Input.GetAxis("Mouse Y") * rotation;

		body.angularVelocity = Vector3.zero;

		transform.Rotate(new Vector3(0, h, 0));
		cam.Rotate(new Vector3(-v, 0, 0));

		if (body.velocity.magnitude > 1 && !mAudio.isPlaying) {
			mAudio.Play ();
		} else if (body.velocity.magnitude <= 1){
			mAudio.Stop ();
		}
	}

	void OnCollisionEnter(Collision other){
		//print ("COLLISION");
		foreach (ContactPoint contactPoint in other.contacts) {
			//print ("AAA");
			//print (Vector3.Angle (contactPoint.normal, Vector3.up) );
			if (Vector3.Angle (contactPoint.normal, Vector3.up) < maxFloorSlope) {
				canJump = true;
			}
		}
	}
}
