using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeCorridorTrigger : MonoBehaviour
{
    GameManager gmScript;
    Animator doorHomeAnim;

    [SerializeField] GameManager gameManager;
    [SerializeField] GameObject doorHome;
    [SerializeField] GameObject endBlockade;

    void Start()
    {
        doorHomeAnim = doorHome.GetComponent<Animator>();
        gmScript = gameManager.GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            gmScript.hasCard = false;
        }

        if (doorHomeAnim.GetBool("NarrowDoorOpen") == true) {
            doorHomeAnim.SetBool("NarrowDoorOpen", false);
            AkSoundEngine.PostEvent("door_close", gameObject);
        }

        endBlockade.SetActive(true);

        Destroy(gameObject);
    }
}
