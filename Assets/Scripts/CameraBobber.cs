using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBobber : MonoBehaviour {

 	public float walkingBobbingSpeed = 14f;
    public float bobbingAmount = 0.05f;
    public PlayerMovement playerMovement;
    public float footstepCD = 0.01f;

    float defaultPosY = 0;
    float timer = 0;
    bool footstepOnCD = false;
    float timeSinceFootstep = 0;

    void Start()
    {
        defaultPosY = transform.localPosition.y;
    }

    void Update()
    {
        if(footstepOnCD) {
            timeSinceFootstep += Time.deltaTime;
            if (timeSinceFootstep >= footstepCD) {
                timeSinceFootstep = 0;
                footstepOnCD = false;
            }
        }

        if(Mathf.Abs(playerMovement.move.x) > 0.1f || Mathf.Abs(playerMovement.move.z) > 0.1f)
        {
            //Player is moving
            timer += Time.deltaTime * walkingBobbingSpeed;
            transform.localPosition = new Vector3(transform.localPosition.x, defaultPosY + Mathf.Sin(timer) * bobbingAmount, transform.localPosition.z);
        
            // Debug.Log(Mathf.Abs(Mathf.Sin(timer)));

            if (Mathf.Abs(Mathf.Sin(timer)) > 0.95 && !footstepOnCD) {
                AkSoundEngine.PostEvent("footstep", gameObject);
                footstepOnCD = true;
            }
        }
        else
        {
            //Idle
            timer = 0;
            transform.localPosition = new Vector3(transform.localPosition.x, Mathf.Lerp(transform.localPosition.y, defaultPosY, Time.deltaTime * walkingBobbingSpeed), transform.localPosition.z);
        }
    }
}
