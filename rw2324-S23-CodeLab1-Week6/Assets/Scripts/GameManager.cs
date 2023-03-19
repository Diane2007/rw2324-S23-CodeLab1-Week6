using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class GameManager : MonoBehaviour
{
    //create a singleton and attach it to GameManagerHolder
    public static GameManager instance;
    
    

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
    
    //create a container for player's input answer
    [FormerlySerializedAs("answer")] public string playerAnswer;
    public string correctAnswer;
    
    //a bool to help check if the answers
    public bool isAnswered = false;
    public bool isCorrect = false;
    public bool isWrong = false;
    
    //public List<string> playerAnswer;

    void Update()
    {
        if (isAnswered == true)
        {
            if (correctAnswer == playerAnswer)
            {
                isCorrect = true;
                Debug.Log("Correct!");
            }
            else
            {
                isWrong = true;
                Debug.Log("Wrong!");
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
