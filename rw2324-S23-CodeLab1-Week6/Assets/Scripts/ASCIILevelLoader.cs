using System;
using System.Collections;
using System.Collections.Generic;
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
    
    // //bools to check if anything is playing, or if the sound has played
    // bool isPlaying = false;
    public bool hasPlayed = false;

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

    void LoadLevel()
    {
        hasPlayed = false;
        //customize each level name and replace the LevelNum.txt file name
        string newPath = FILE_PATH.Replace("Num", currentLevel + "");
        
        //read all lines from the txt file and store it in fileContents
        string[] fileContents = File.ReadAllLines(newPath);
        
        //create a list to store the current level's test answers
        List<string> testAnswer = new List<string>();   //DONT FORGET TO CLEAR THE LIST

        //go through each string in the array
        for (int note = 0; note < fileContents.Length; note++)
        {
            //put each string into a box called noteName
            string noteName = fileContents[note];
            Debug.Log("the current note is: " + noteName);
            
            //add each played note into the list of testAnswer
            testAnswer.Add(noteName);

            //play respective note sound
            switch (noteName)
            {
                case "C":   //is the note C?
                    noteC.PlayOneShot(noteC.clip);      //play noteC
                    Debug.Log("Now playing: C");
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
                case "Bb":
                    noteASh.PlayOneShot(noteASh.clip);
                    Debug.Log("Now playing: Bb");
                    break;
                default:
                    Debug.Log("No sound played!");
                    break;
                    
            }

            hasPlayed = true;
            
            //if player's answer is the same as test answer
            //the level is completed
            if (GameManager.instance.playerAnswer == testAnswer)
            {
                
            }
            
        }

    }
    
}
