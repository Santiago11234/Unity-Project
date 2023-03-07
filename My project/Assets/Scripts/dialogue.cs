using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class dialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textspeed;
    private bool inTrigger = false;
    GameObject DialogueBox;

    private int index;
    // Start is called before the first frame update
    void Start()
    {
        /* textComponent.text = string.Empty;
         StartDialogue(); */
        DialogueBox = GameObject.Find("DialogueBox"); DialogueBox.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (inTrigger == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (textComponent.text == lines[index])
                {
                    NextLine();
                }
                else
                {
                    StopAllCoroutines();
                    textComponent.text = lines[index];
                }
            }
        }
    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textspeed);
        }
    }

    void NextLine()
    {
        if(index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);
            DialogueBox.SetActive(false);
            inTrigger = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
         if (other.gameObject.tag == "MainCamera")
        {
            Debug.Log("your mom");
            inTrigger = true;
            DialogueBox.SetActive(true);
        }
    } 
}
