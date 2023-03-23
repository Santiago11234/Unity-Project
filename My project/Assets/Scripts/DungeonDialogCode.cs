using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class DungeonDialogCode : MonoBehaviour
{
    public TMP_Text text = null;
    public string[] arr;
    public int pos = 0;

    // Start is called before the first frame update
    void Start()
    {
        arr = new string[4];
        arr[0] = "Hello there pirate";
        arr[1] = "Do you want some treasure?";
        arr[2] = "Find 10 coins to open the treasure trove!!";
        arr[3] = "Are you ready to open your treausre and end the game?";
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Debug.Log("wassap");
        if (Input.GetKeyDown(KeyCode.C))
        {
            text.text = arr[pos];
            incrementDialogue();
            Debug.Log("hello");
        }
        
    }


    public void incrementDialogue() {
        pos++;
        
    }

    
}
