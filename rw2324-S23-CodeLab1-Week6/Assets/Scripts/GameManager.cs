using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class GameManager : MonoBehaviour
{

    // //add piano note audio to inspector
    // public AudioSource
    //     noteC, noteCSh, noteD, noteDSh, noteE, noteF, noteFSh, noteG, noteGSh, noteA, noteASh, noteB, noteBSh;

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
