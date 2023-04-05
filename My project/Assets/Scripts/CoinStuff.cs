using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CoinStuff : MonoBehaviour
{
    public int amtOfCoins;
    public TMP_Text text = null;
    public bool inDungeon;
    public int amtNeeded = 5;
    public GameObject g = null;
    bool end  = false;

    // Start is called before the first frame update
    void Start()
    {
    
        
        if(inDungeon) {
            amtNeeded = 5;
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
            text.text = "The End. Press R to replay";
            end = true;
        }

        if(end) {
            if(Input.GetKeyDown(KeyCode.R))
                 SceneManager.LoadScene("Start Screen");
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
            // if(!inDungeon)
            //     amtOfCoins--;

        }

        if(inDungeon && amtOfCoins == 5 && other.gameObject.tag == "OkButtonTest") {

            g = GameObject.FindGameObjectWithTag("EndWall");

         }
    }
}
