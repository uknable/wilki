using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoudSwitch : MonoBehaviour
{
    [SerializeField] GameObject wendy;
    [SerializeField] GameObject andrew;

    AkAmbient andrewScript;
    AkAmbient wendyScript;


    void Start()
    {
        andrewScript = andrew.GetComponent<AkAmbient>();
        wendyScript = wendy.GetComponent<AkAmbient>();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {

            andrewScript.enabled = false;
            wendyScript.enabled = false;


            AkSoundEngine.PostEvent("VCE_andrew_loud", andrew);
            AkSoundEngine.PostEvent("VCE_wendy_loud", wendy);
        }
    }

}
