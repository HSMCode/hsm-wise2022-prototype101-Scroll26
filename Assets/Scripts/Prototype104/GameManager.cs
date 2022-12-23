using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    void Awake()
    {
        // Keep this game object loaded even on scene change
        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {
        // Load Prototype104_myJump scene
        SceneManager.LoadScene(3);
        Debug.Log("Test");
    }
}
