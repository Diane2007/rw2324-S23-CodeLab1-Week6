using System;
using System.Collections.Generic;
using UnityEngine;

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
    
    //create a list for player's input answer
    public List<string> playerAnswer;

    //
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
