using System;
using System.Collections;
using UnityEngine;
using System.IO;

public class ASCIILevelLoader : MonoBehaviour
{
    //add piano note audio to inspector
    public AudioSource
        noteC, noteCSh, noteD, noteDSh, noteE, noteF, noteFSh, noteG, noteGSh, noteA, noteASh, noteB, noteBSh;
    //now doing accidental notes but in flats for enharmonic equivalents
    public AudioSource
        noteBb, noteEb;
    
    //making the script a singleton and attach it to GameManagerHolder
    public static ASCIILevelLoader instance;
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

    //set a timer
    float timer = 0f;
    public float testPlayTime = 2;
    public float testWaitTime = 1;
    
    //bools to check if anything is playing, or if the sound has played
    bool isPlaying = false;
    bool hasPlayed = false;

    //make a property to store the current level
    int currentLevel = 0;
    public int CurrentLevel
    {
        get { return currentLevel; }
        set
        {
            currentLevel = value;
            LoadLevel();

        }
    }
    
    //preparing for input-output
    const string FILE_NAME = "LevelNum.txt";
    const string FILE_DIR = "/Levels/";
    string FILE_PATH;

    void Start()
    {
        //define file path
        FILE_PATH = Application.dataPath + FILE_DIR + FILE_NAME;
        LoadLevel();
    }

    // public void PlayTestSound(string noteX)
    // {
    //     
    // }
    //
    // void WaitTest()
    // {
    //     if (!isPlaying && !hasPlayed)
    //     {
    //         timer += Time.deltaTime;
    //         if (timer > testPlayTime)
    //         {
    //             PlayTestSound();
    //             timer = 0;
    //             hasPlayed = true;
    //         }
    //     }
    // }

    void LoadLevel()
    {
        //customize each level name and replace the LevelNum.txt file name
        string newPath = FILE_PATH.Replace("Num", currentLevel + "");
        
        //read all lines from the txt file and store it in fileContents
        string[] fileContents = File.ReadAllLines(newPath);

        //go through each string in the array
        for (int note = 0; note < fileContents.Length; note++)
        {
            //put each string
            string noteName = fileContents[note];
            Debug.Log(noteName);

            //play respective note sound
            switch (noteName)
            {
                case "C":   //is the note C?
                    noteC.PlayOneShot(noteC.clip);      //play noteC
                    Debug.Log("Now playing: " + noteC.clip.ToString());
                    break;
                case "D":   //is the note D?
                    noteD.PlayOneShot(noteD.clip);
                    Debug.Log("Now playing: D");
                    break;
                case "E":
                    noteE.PlayOneShot(noteE.clip);
                    Debug.Log("Now playing: E");
                    break;
                case "Eb":
                    noteEb.PlayOneShot(noteEb.clip);
                    Debug.Log("Now playing: Eb");
                    break;
                case "F":
                    noteF.PlayOneShot(noteF.clip);
                    Debug.Log("Now playing: F");
                    break;
                case "G":
                    noteG.PlayOneShot(noteG.clip);
                    Debug.Log("Now playing: G");
                    break;
                default:
                    Debug.Log("No sound played!");
                    break;
                    
            }
        }

    }
    
}
