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
        // Load Prototype103_Jump scene
        SceneManager.LoadScene(3);
    }
}
