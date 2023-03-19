using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThumbsDownStay : MonoBehaviour
{
    //same reason as ThumbsUpStay
    public static ThumbsDownStay instance;

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
