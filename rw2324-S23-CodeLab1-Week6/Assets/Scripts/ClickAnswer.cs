using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAnswer : MonoBehaviour
{
    //these are the answers that can be attached to each button
    public enum NoteAnswer
    {
        C, Cmaj3, Cmaj, Cmaj7
    }
    
    //default choice is C
    public NoteAnswer inputAnswer = NoteAnswer.C;

    //store each button's answer
    public string answer;
    public void PlayerAnswer()
    {
        switch (inputAnswer)
        {
            case NoteAnswer.C:      //button is for the answer C
                GameManager.instance.playerAnswer = "C";
                GameManager.instance.isAnswered = true;
                Debug.Log("Clicked, player answer is: " + GameManager.instance.playerAnswer);
                //answer = "C";
                //GameManager.instance.playerAnswer.Add("C");
                Debug.Log("Player answer is C");
                break;
            case NoteAnswer.Cmaj3:  //button is for the answer Cmaj3
                GameManager.instance.playerAnswer = "Cmaj3";
                // GameManager.instance.playerAnswer.Add("C");
                // GameManager.instance.playerAnswer.Add("E");
                Debug.Log("Player answer is Cmaj3");
                break;
            case NoteAnswer.Cmaj:   //button is for the answer Cmaj
                GameManager.instance.playerAnswer = "Cmaj";
                // GameManager.instance.playerAnswer.Add("C");
                // GameManager.instance.playerAnswer.Add("E");
                // GameManager.instance.playerAnswer.Add("G");
                Debug.Log("Player answer is Cmaj");
                break;
            case NoteAnswer.Cmaj7:  //button is for the answer Cmaj7
                GameManager.instance.playerAnswer = "Cmaj7";
                // GameManager.instance.playerAnswer.Add("C");
                // GameManager.instance.playerAnswer.Add("E");
                // GameManager.instance.playerAnswer.Add("G");
                // GameManager.instance.playerAnswer.Add("B");
                Debug.Log("Player answer is Cmaj7");
                break;
            default:
                Debug.Log("No answer!!!");
                break;
        }
    }

}
