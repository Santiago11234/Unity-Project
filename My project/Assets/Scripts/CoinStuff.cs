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
    bool end  = false;

    // Start is called before the first frame update
    void Start()
    {
    
        
        if(inDungeon) {
            amtNeeded = 10;
            amtOfCoins = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(!end) 
            text.text = "Coins: " + amtOfCoins + " / " + amtNeeded;

        if(g != null && g.transform.position.x < 15.634f) {
            g.transform.Translate (5 * Time.deltaTime, 0, 0);
            text.text = "The End";
            end = true;
        }
         
    }

    void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "coin"){
            
            Destroy(other.gameObject);
            // if(other.gameObject.name == "PirateCoinRock") {
            //     amtOfCoins--;
            // }
            for(int i = 0; i < 1000000; i++) {

            }
            amtOfCoins++;

        }

        if(inDungeon && amtOfCoins == 10 && other.gameObject.tag == "OkButtonTest") {

            g = GameObject.FindGameObjectWithTag("EndWall");

         }
    }
}
*/