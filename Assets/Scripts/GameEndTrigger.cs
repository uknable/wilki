using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEndTrigger : MonoBehaviour {

	[SerializeField]
	GameObject floor;
	private void OnTriggerEnter(Collider other) {
		Destroy(floor);
	}
}
