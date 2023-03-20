using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickAnswer : MonoBehaviour
{
    //these are the answers that can be attached to each button
    public enum NoteAnswer
    {
        C, Cmaj3, Cmaj, Cmaj7
    }
    
    //default choice is C
    public NoteAnswer inputAnswer = NoteAnswer.C;

    public void PlayerAnswer()
    {
        switch (inputAnswer)
        {
            case NoteAnswer.C:      //button is for the answer C
                GameManager.instance.playerAnswer = "C";
                GameManager.instance.isAnswered = true;
                //Debug.Log("Clicked, player answer is: " + GameManager.instance.playerAnswer);
                break;
            case NoteAnswer.Cmaj3:  //button is for the answer Cmaj3
                GameManager.instance.playerAnswer = "Cmaj3";
                GameManager.instance.isAnswered = true;
                break;
            case NoteAnswer.Cmaj:   //button is for the answer Cmaj
                GameManager.instance.playerAnswer = "Cmaj";
                GameManager.instance.isAnswered = true;
                break;
            case NoteAnswer.Cmaj7:  //button is for the answer Cmaj7
                GameManager.instance.playerAnswer = "Cmaj7";
                GameManager.instance.isAnswered = true;
                break;
            default:
                Debug.Log("No answer!!!");
                break;
        }
    }

}
