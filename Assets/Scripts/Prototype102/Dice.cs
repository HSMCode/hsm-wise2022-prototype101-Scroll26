using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    private int DiceValue;

    public int[] luckyNumbers = {1, 25, 6, 11, 22, 33, 44, 50};
    public GameObject[] MyGameObjectArray;
    public AudioSource winSound;

    // Start is called before the first frame update
    void Start()
    {
        winSound = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("space"))
        {
            DiceValue = Random.Range(1, 51);
            // Debug.Log(DiceValue);
    
            for(int i = 0; i < luckyNumbers.Length; i++)
            {
                // do this
                if (DiceValue == luckyNumbers[i])
                {
                    Debug.Log("Gewonnen, deine Glückszahl war " + DiceValue);
                    winSound.Play();
                }
            }
        }
    }
}
