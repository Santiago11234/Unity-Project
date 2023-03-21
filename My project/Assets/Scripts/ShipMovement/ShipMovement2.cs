using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShipMovement2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {


    }


    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 150)
        {
            transform.Translate(0, 0, -91.34f-150);
        }
        transform.Translate(0, 0, 0.02f);
    }
}





