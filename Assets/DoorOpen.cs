using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour {

	public Transform customPivot;

	public float openSpeed;

	Animator animator;
	bool playerNear;

	void Update()
	{
		

		// transform.RotateAround(customPivot.position, Vector3.up, openSpeed * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player") {
			Debug.Log("Hello Player");
		}
	}
}
