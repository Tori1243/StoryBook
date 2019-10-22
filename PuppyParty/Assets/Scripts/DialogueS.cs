using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


public class DialogueS : MonoBehaviour
{
    public string text;

    public UnityEvent EndOfTextEvent;

   // public Panel panel;
    
    public Text DialogueBox;
    
    //Call when DialogueBox is opened
    
    public void DisplayText()
    {
       // DialogueBoxText = text
    }
    
    // call when next button is pressed
    
    public void CloseBox()
    {
        
    }
    
    
}
