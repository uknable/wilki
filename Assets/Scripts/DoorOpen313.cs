using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen313 : MonoBehaviour {

	public float openSpeed;

	Animator animator;
	public bool isOpen = false;
	GameManager gmScript;

	[SerializeField]
	GameObject gameManager;

	void Awake()
	{
		animator = GetComponent<Animator>();
		gmScript = gameManager.GetComponent<GameManager>();
	}

	void OnTriggerStay(Collider other) {
		if (other.tag == "Player" && Input.GetMouseButtonDown(0)) {
			isOpen = !isOpen;
			animator.SetBool("DoorOpen313", isOpen);
			AkSoundEngine.PostEvent("card_accept", gameObject);
		}
	}

	private void Update() {
		Debug.Log(gmScript.hasCard);
	}
}
