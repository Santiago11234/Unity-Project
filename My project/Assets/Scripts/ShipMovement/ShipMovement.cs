using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShipMovement : MonoBehaviour
{


public bool special;

    // Start is called before the first frame update
    void Start()
    {

        

    }


    // Update is called once per frame
    void Update()
    {

        if(special) {
             if (transform.position.x < 0)
            {
                transform.Translate(0, 0, -91.7f - 100 * Time.deltaTime);
            }
            transform.Translate(0, 0, 0.02f);
        }

        else {
            if (transform.position.x < -100)
            {
                transform.Translate(0, 0, -91.7f - 100 * Time.deltaTime);
            }
            transform.Translate(0, 0, 0.02f);
        }
        
    }
}

//115-15

