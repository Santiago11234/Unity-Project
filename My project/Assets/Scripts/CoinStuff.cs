using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinStuff : MonoBehaviour
{
    public int amtOfCoins;

    // Start is called before the first frame update
    void Start()
    {
        amtOfCoins = 0;
    }

    // Update is called once per frame
    void Update()
    {
  
    }

    void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "coin"){
            amtOfCoins++;
            Destroy(other.gameObject);
        }
            
    }
}
