using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputAnswer : MonoBehaviour
{
    //make InputAnswer a singleton and attach it to Piano_NoSound
    public static InputAnswer instance;
    void Awake()
    {
        if (!instance)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    //create the drop down menus
    public enum ClickAnswer
    {
        C, D, E, F, G, A, B,
        CSh, DSh, FSh, GSh, ASh, BSh,
    }
    
    //set a default: C
    public ClickAnswer keyName = ClickAnswer.C;

    void OnMouseOver()
    {
        //when the mouse is over the collider
        //if the left key is pressed and the test sound has played
        if (Input.GetMouseButtonDown(0) && GameManager.instance.GetComponent<ASCIILevelLoader>().hasPlayed)
        {
            switch (keyName)
            {
                case ClickAnswer.C:
                    GameManager.instance.playerAnswer.Add("C");
                    break;
                case ClickAnswer.CSh:
                    GameManager.instance.playerAnswer.Add("C#");
                    break;
                case ClickAnswer.D:
                    GameManager.instance.playerAnswer.Add("D");
                    break;
                case ClickAnswer.E:
                    GameManager.instance.playerAnswer.Add("E");
                    break;
                case ClickAnswer.F:
                    GameManager.instance.playerAnswer.Add("F");
                    break;
                case ClickAnswer.FSh:
                    GameManager.instance.playerAnswer.Add("F#");
                    break;
                case ClickAnswer.G:
                    GameManager.instance.playerAnswer.Add("G");
                    break;
                case ClickAnswer.GSh:
                    GameManager.instance.playerAnswer.Add("G#");
                    break;
                case ClickAnswer.A:
                    GameManager.instance.playerAnswer.Add("A");
                    break;
                case ClickAnswer.B:
                    GameManager.instance.playerAnswer.Add("B");
                    break;
                case ClickAnswer.ASh:
                    GameManager.instance.playerAnswer.Add("Bb");
                    break;
                case ClickAnswer.DSh:
                    GameManager.instance.playerAnswer.Add("Eb");
                    break;
                case ClickAnswer.BSh:
                    GameManager.instance.playerAnswer.Add("B#");
                    break;
                default:
                    Debug.Log("You're not giving a correct input");
                    break;
            }
        }
    }
}
