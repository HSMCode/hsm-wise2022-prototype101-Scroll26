using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            // Get inforamtion about active scene and load/reload this scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
