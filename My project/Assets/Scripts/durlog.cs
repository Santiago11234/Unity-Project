using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
//using Unity.Mathematics;
using UnityEngine.SceneManagement;

public class durlog : MonoBehaviour
{

    public TMP_Text DIALOGUE;
    int amt = 0;
    string d1 = "- Welcome pirate, how was your journey?"; 
    string d2 = "Where am I, what happened?";
    string d3 = "I found you stranded on this island out cold."; 
    string d4 = " Out cold? Do you mean I made it?!?!";
    string d5 = "That is precisely what I mean, congratulations";
    string d6 = " I can't believe it. Where's the treasure?";
    string d7 = "right here :p";
   /* string d8 = "duzmzzzz grrrrzzzz bz bz wuz";
    string d9 = "izioom! *the two bugs check out (the groceries costed $63.23)";
    string d10 = "buzuzuzuzzuzz";
    string d11 = "mhmrmrmrmmrmrmmrmrwwh . . . . . . *the bugs stomach rumbles~*";
    string d12 = "zip no trzz. . . :- (";
    string d13 = "pizz";
    string d14 = "rzizzz!! wahoo bzz";
    string d15 = "buzzbeeble";
    string d16 = "zizzzle weezle!";
    string d17 = "zzzzz the end! zzzzz"; */
    public string[] values;
    // Start is called before the first frame update
    void Start()
    {
        DIALOGUE.text = d1;
        values = new string[17];
        values[0] = d2;
        values[1] = d3;
        values[2] = d4;
        values[3] = d5;
        values[4] = d6;
        values[5] = d7;
       /* values[6] = d8;
        values[7] = d9;
        values[8] = d10;
        values[9] = d11;
        values[10] = d12;
        values[11] = d13;
        values[12] = d14;
        values[13] = d15;
        values[14] = d16;
        values[15] = d17; */



    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetMouseButtonDown(0))
        //if (Input.GetKey(KeyCode.Space))
        {

            DIALOGUE.text = values[amt]; ;
            amt++;
        }
    }
}

