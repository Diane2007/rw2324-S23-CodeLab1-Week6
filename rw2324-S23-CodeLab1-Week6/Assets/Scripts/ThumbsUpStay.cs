using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThumbsUpStay : MonoBehaviour
{
    //Unity is unhappy when going to end scene
    //because AsciiLoader is still trying to use thumbsUp there
    //when thumbs up doesn't exist in the scene
    //so I'll make it a singleton because I'm too lazy to check if thumbsUp is null in AsciiLoader
    public static ThumbsUpStay instance;
    
    //init a var to store the current scene build index
    int sceneNumber;

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
}
