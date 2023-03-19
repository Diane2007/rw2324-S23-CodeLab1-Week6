using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class TestManager : MonoBehaviour
{
    //singleton setup
    public static TestManager instance;
    
    //using prefabs to generate sound, defining them here
    GameObject testSound;
    [FormerlySerializedAs("c4")] public GameObject noteC4;


    //making the TestManagerHolder a singleton
    void Awake()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }

        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        PlayTestSound();
        
    }

    void PlayTestSound()
    {
        testSound = Instantiate<GameObject>(noteC4);

        AudioSource audioSource = testSound.GetComponent<AudioSource>();
        audioSource.clip = Resources.Load<AudioClip>("Audio/c4");
        
        audioSource.PlayOneShot(audioSource.clip);
    }
}