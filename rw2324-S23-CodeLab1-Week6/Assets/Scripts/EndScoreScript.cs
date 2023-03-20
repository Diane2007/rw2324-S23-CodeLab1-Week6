using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EndScoreScript : MonoBehaviour
{
    void Start()
    {
        GetComponent<TextMeshProUGUI>().text = "Your score: " + "\n" + GameManager.instance.Score;
    }
}
