using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadNewScene()
    {
        SceneManager.LoadScene("TestScene");
    }

}
