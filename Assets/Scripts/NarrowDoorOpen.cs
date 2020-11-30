using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarrowDoorOpen : MonoBehaviour {

	public float openSpeed;

	Animator animator;
	bool isOpen = false;
	GameManager gmScript;

	[SerializeField]
	GameObject gameManager;

	void Awake()
	{
		animator = GetComponent<Animator>();
		gmScript = gameManager.GetComponent<GameManager>();
	}

	void OnTriggerStay(Collider other) {
		if (other.tag == "Player" && Input.GetMouseButtonDown(0) && gmScript.hasCard) {
			isOpen = !isOpen;
			animator.SetBool("NarrowDoorOpen", isOpen);
			AkSoundEngine.PostEvent("door_handle", gameObject);
		}
	}
}
