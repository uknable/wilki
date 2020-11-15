using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door313Trigger : MonoBehaviour {

	Animator anim;
	DoorOpen313 door313Script;

	[SerializeField]
	GameObject door313;

	private void Awake() {
		anim = door313.GetComponent<Animator>();
		door313Script = door313.GetComponent<DoorOpen313>();
	}

	private void OnTriggerEnter(Collider other) {
		if (other.tag == "Player") {
			
			door313Script.isOpen = !door313Script.isOpen;
			anim.SetBool("DoorOpen313", door313Script.isOpen);

			AkSoundEngine.PostEvent("card_accept", door313);

			Destroy(gameObject);
		}
	}
}
