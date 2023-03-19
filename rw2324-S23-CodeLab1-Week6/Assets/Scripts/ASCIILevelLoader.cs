using System;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ASCIILevelLoader : MonoBehaviour
{
    //add piano note audio to inspector
    public AudioSource
        noteC, noteCSh, noteD, noteDSh, noteE, noteF, noteFSh, noteG, noteGSh, noteA, noteASh, noteB, noteBSh;

    //the thumbs up sprite
    public GameObject thumbsUp;
    
    // //bools to check if anything is playing, or if the sound has played
    // bool isPlaying = false;
    public bool hasPlayed = false;
    
    //init a timer
    float timer = 0f;
    float waitTime = 2f;
    float testTime = 2f;

    //make a property to store the current level
    int currentLevel = 0;
    public int CurrentLevel
    {
        get { return currentLevel; }
        set
        {
            currentLevel = value;
            GameManager.instance.isAnswered = false;
            hasPlayed = false;
            LoadLevel();
        }
    }
    
    //preparing for input-output
    const string FILE_NAME = "LevelNum.txt";
    const string FILE_DIR = "/Levels/";
    string FILE_PATH;

    void Start()
    {
        //don't show the thumbs up at the beginning
        thumbsUp.SetActive(false);
        
        //define file path
        FILE_PATH = Application.dataPath + FILE_DIR + FILE_NAME;
        LoadLevel();
    }

    void LoadLevel()
    {
        //when start level, test sound has not played
        hasPlayed = false;
        
        //customize each level name and replace the LevelNum.txt file name
        string newPath = FILE_PATH.Replace("Num", currentLevel + "");
        
        //read all lines from the txt file and store it in fileContents
        string[] fileContents = File.ReadAllLines(newPath);
        
        //create a container to store the current level's test answers
        //List<string> testAnswer = new List<string>();
        string testAnswer = fileContents[fileContents.Length - 1];
        //store testAnswer in GameManager
        GameManager.instance.correctAnswer = testAnswer;

        //go through each string in the array
        for (int note = 0; note < fileContents.Length - 1; note++)
        {
            //put each string into a box called noteName
            string noteName = fileContents[note];
            Debug.Log("the current note is: " + noteName);
            
            // //add each played note into the list of testAnswer
            // testAnswer.Add(noteName);
            // Debug.Log("Test answer: " + testAnswer[0]);

            //play respective note sound
            switch (noteName)
            {
                case "C":   //is the note C?
                    noteC.PlayOneShot(noteC.clip);      //play noteC
                    Debug.Log("Now playing: C");
                    break;
                case "E":
                    noteE.PlayOneShot(noteE.clip);
                    Debug.Log("Now playing: E");
                    break;
                case "G":
                    noteG.PlayOneShot(noteG.clip);
                    Debug.Log("Now playing: G");
                    break;
                case "B":
                    noteB.PlayOneShot(noteB.clip);
                    Debug.Log("Now playing: B");
                    break;
                default:
                    Debug.Log("No sound played!");
                    break;
                    
            }
            
            //test sound has played turns to true
            hasPlayed = true;
            Debug.Log("The last item of the file content is: " + fileContents[fileContents.Length - 1]);
            Debug.Log("Player's answer is: " + GameManager.instance.playerAnswer);

        }

    }

    void Update()
    {
        //if we have a correct answer
        if (GameManager.instance.isCorrect == true)
        {
            thumbsUp.SetActive(true);
            
            //start timer
            timer += Time.deltaTime;
            if (timer > waitTime)   //if timer is more than waitTime
            {
                thumbsUp.SetActive(false);  //disable thumbs up sprite
                CurrentLevel++;             //go to next level
                timer = 0;                  //reset timer
                GameManager.instance.isCorrect = false;
            }
        }
    }
}
