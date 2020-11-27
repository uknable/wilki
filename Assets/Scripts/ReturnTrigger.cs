using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnTrigger : MonoBehaviour
{
    [SerializeField] GameObject startingPosition;

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            // CharacterController cc = other.GetComponent<CharacterController>();

            // cc.enabled = false;
            other.transform.position = startingPosition.transform.position;
            // cc.enabled = true;
        }
    }
}
