using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShipMovement3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {


    }


    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -100)
        {
            transform.Translate(0, 0, -120.7f - 100);
        }
        transform.Translate(0, 0, 0.5f);
    }
}
