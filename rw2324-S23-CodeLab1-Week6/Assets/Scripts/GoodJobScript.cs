using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GoodJobScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //if score > 0, show good job
        if (GameManager.instance.Score > 0)
        {
            GetComponent<TextMeshProUGUI>().text = "Good Job!";
        }
        else
        {
            GetComponent<TextMeshProUGUI>().text = "Boo boo!";
        }
    }

}
