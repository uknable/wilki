using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour {

	GameManager gmScript;
	Animator anim;
	DoorOpen313 door313Script;

	[SerializeField]
	GameObject gameManager;
	[SerializeField]
	GameObject door313;

	void Awake () {
		anim = door313.GetComponent<Animator>();
		gmScript = gameManager.GetComponent<GameManager>();
		door313Script = door313.GetComponent<DoorOpen313>();
	}
	

	void OnTriggerStay(Collider other) {
		if (other.tag == "Player" && Input.GetMouseButtonDown(0)) {

			door313Script.isOpen = !door313Script.isOpen;
			anim.SetBool("DoorOpen313", door313Script.isOpen);

			AkSoundEngine.PostEvent("door_close", door313);

			gmScript.hasCard = true;
			Destroy(gameObject);
		}
	}
}
