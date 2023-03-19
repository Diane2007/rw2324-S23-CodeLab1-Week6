using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class GameManager : MonoBehaviour
{
    //create a singleton and attach it to GameManagerHolder
    public static GameManager instance;
    public TextMeshProUGUI scoreText;

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
        
    //create a box for scores, making it a property
    int score = 0;
    //bools to make sure ChangeScore() only calls once
    bool scoreChanged = false;
    public int Score
    {
        get { return score; }
        set
        {
            //reset scoreChanged
            //scoreChanged = false;
            score = value;
            //whenever score changes, change scoreText
            ChangeScore(); 
            
        }
    }
    
    //create a container for player's input answer
    [FormerlySerializedAs("answer")] public string playerAnswer;
    public string correctAnswer;
    
    //a bool to help check if the answers
    public bool isAnswered = false;
    public bool isCorrect = false;
    public bool isWrong = false;

    void Start()
    {
        //show the score text
        ChangeScore();
    }

    void ChangeScore()
    {
        scoreText.text = "Your score:" + "\n" + Score;
        isAnswered = false;
        Debug.Log("After changing score, isAnswered is " + isAnswered);
    }

    void Update()
    {
        if (isAnswered == true)
        {
            if (correctAnswer == playerAnswer)
            {
                Debug.Log("Correct!");
                Debug.Log("score changed bool is: " + scoreChanged.ToString() + " isAnswered is: " + isAnswered.ToString());
                isCorrect = true;
                if(scoreChanged == false)
                {
                    Score++;    //score +1 when correct
                    scoreChanged = true;
                }
            }
            else
            {
                Debug.Log("Wrong!");
                Debug.Log("score changed bool is: " + scoreChanged.ToString() + "isAnswered is: " + isAnswered.ToString());
                isWrong = true;
                if(scoreChanged == false)
                {
                    Score--;    //score -1 when wrong
                    scoreChanged = true;
                }
            }

        }

    }
    // void Update()
    // {
    //     WaitTest();
    //     if (isPlaying)
    //     {
    //         timer += Time.deltaTime;
    //         if (timer > testPlayTime)
    //         {
    //             StopTestSound();
    //             timer = 0;
    //         }
    //     }
    // }
    //
    // void StopTestSound()
    // {
    //     noteC.Stop();
    //     isPlaying = false;
    // }
    //
    // void PlayTestSound()
    // {
    //     noteC.PlayOneShot(noteC.clip);
    //     isPlaying = true;
    // }
    //
    // void WaitTest()
    // {
    //     if (!isPlaying && !hasPlayed)
    //     {
    //         timer += Time.deltaTime;
    //         if (timer > testWaitTime)
    //         {
    //             PlayTestSound();
    //             timer = 0;
    //             hasPlayed = true;
    //         }
    //     }
    // }
}
