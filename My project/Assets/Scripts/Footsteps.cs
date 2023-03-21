using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    PlayerMovement pm;
    jump jp;
    //PlayerMovement rb;
    

    // Start is called before the first frame update
    void Start()
    {
        pm = GetComponent<PlayerMovement>();
        jp = GetComponent<jump>();
        //rb = GetComponent<RigidBody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (jp.jumped == false && pm.isMoving == true && GetComponent<AudioSource>().isPlaying == false)
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
