using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    private int DiceValue;
    /* private int LuckyOne = 6;
    private int LuckyTwo = 1;
    private int LuckyThree = 3; */

    public int[] luckyNumbers = {1, 3, 6};
    public GameObject[] MyGameObjectArray;

    // public int[] luckyNumbers = new int[3];

    // Start is called before the first frame update
    void Start()
    {
        /* luckyNumbers[0] = 1;
        luckyNumbers[1] = 2;
        luckyNumbers[2] = 3; */
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("space"))
        {
            DiceValue = Random.Range(1, 7);
            // Debug.Log(DiceValue);
    
            for(int i = 0; i < luckyNumbers.Length; i++)
            {
                // do this
                if (DiceValue == luckyNumbers[i])
                {
                    Debug.Log("Gewonnen, deine Glückszahl war " + DiceValue);
                }
            }

            /* if (DiceValue == luckyNumbers[0] || DiceValue == luckyNumbers[1] || DiceValue == luckyNumbers[2])
            {
                Debug.Log("Gewonnen, deine Glückszahl war " + DiceValue);
            }
            else
            {
                Debug.Log("Verloren, deine Zahl war " + DiceValue);
            } */
        }
    }
}
