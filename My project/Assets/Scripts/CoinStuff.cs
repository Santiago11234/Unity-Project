using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinStuff : MonoBehaviour
{
    public int amtOfCoins;
    public TMP_Text text = null;

    // Start is called before the first frame update
    void Start()
    {
        amtOfCoins = 0;
        text.text = "Coins: 0/5";
    }

    // Update is called once per frame
    void Update()
    {
         text.text = "Coins: " + amtOfCoins + " / 5";
    }

    void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "coin"){
            amtOfCoins++;
            Destroy(other.gameObject);
            // if(other.gameObject.name == "PirateCoinRock") {
            //     amtOfCoins--;
            // }
           

        }
    }
}
