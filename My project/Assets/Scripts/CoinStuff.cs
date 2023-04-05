/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinStuff : MonoBehaviour
{
    public int amtOfCoins;
    public TMP_Text text = null;
    public bool inDungeon = false;
    public int amtNeeded = 5;
    public GameObject g = null;

    // Start is called before the first frame update
    void Start()
    {
        amtOfCoins = 10;
        text.text = "Coins: 0/5";
        
        if(inDungeon) {
            amtNeeded = 10;
            amtOfCoins = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
         text.text = "Coins: " + amtOfCoins + " / " + amtNeeded;
        if(g != null && g.transform.position.x < 15.634f) {
            g.transform.Translate (5 * Time.deltaTime, 0, 0);
        }
         
    }

    void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "coin"){
            amtOfCoins++;
            Destroy(other.gameObject);
            // if(other.gameObject.name == "PirateCoinRock") {
            //     amtOfCoins--;
            // }

        }

        if(inDungeon && amtOfCoins == 10 && other.gameObject.tag == "OkButtonTest") {

            g = GameObject.FindGameObjectWithTag("EndWall");

         }
    }
}
*/