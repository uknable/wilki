using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnTrigger : MonoBehaviour
{
    // [SerializeField] GameObject startingPosition;
    // [SerializeField] GameObject startingLookAt;

    // private void OnTriggerEnter(Collider other) {
    //     if (other.tag == "Player") {
            
	// 		AkSoundEngine.PostEvent("VCE_scream", other.gameObject);

    //         other.transform.position = startingPosition.transform.position;
    //         other.transform.LookAt(startingLookAt.transform);
    //     }
    // }

    [SerializeField] GameObject floor;

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            Destroy(floor);
            AkSoundEngine.PostEvent("VCE_scream", other.gameObject);
        }
    }
}
