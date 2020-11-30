using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorJammed : MonoBehaviour
{
	void OnTriggerStay(Collider other) {
		if (other.tag == "Player" && Input.GetMouseButtonDown(0)) {
			AkSoundEngine.PostEvent("door_open", gameObject);
		}
	}
}
