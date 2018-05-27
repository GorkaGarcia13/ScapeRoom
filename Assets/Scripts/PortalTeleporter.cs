using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTeleporter : MonoBehaviour {

	public Transform player, otherPortal, thisPortal;

	private bool playerIsOverlapping = false;
	
	// Update is called once per frame
	void Update () {
		if (playerIsOverlapping)
		{
			//print("teleport");
			Vector3 portalToPlayer = player.position - transform.position;
			float dotProduct = Vector3.Dot(transform.up, portalToPlayer);

			if (dotProduct < 0f)
			{
				Vector3 relativePosition = thisPortal.InverseTransformPoint (player.position);

				player.position = otherPortal.TransformPoint (relativePosition);

				player.rotation = otherPortal.rotation * (Quaternion.Inverse(thisPortal.rotation) * player.rotation);

				playerIsOverlapping = false;

				// poner de pie

				Quaternion standUpRotation = Quaternion.FromToRotation (player.up, Vector3.up);
				player.rotation = standUpRotation * player.rotation;
			}
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player"){
			playerIsOverlapping = true;
			//print("true");
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.tag == "Player")
		{
			playerIsOverlapping = false;
		}
	}
}
