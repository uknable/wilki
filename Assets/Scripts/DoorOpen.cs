using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour {

	public float openSpeed;

	Animator animator;
	bool isOpen = false;

	void Start()
	{
		animator = GetComponent<Animator>();
	}

	void OnTriggerStay(Collider other) {
		if (other.tag == "Player" && Input.GetMouseButtonDown(0)) {
			isOpen = !isOpen;
			animator.SetBool("DoorOpen", isOpen);
		}
	}
}
