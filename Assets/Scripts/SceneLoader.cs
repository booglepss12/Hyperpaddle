using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Invoke("LoadNextScene", 2f);
    }

    void LoadNextScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}