using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    private int DiceValue;
    private int LuckyOne = 6;
    private int LuckyTwo = 1;
    private int LuckyThree = 3;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("space"))
        {
            DiceValue = Random.Range(1, 7);
            Debug.Log(DiceValue);
        }

        if (DiceValue == LuckyOne || DiceValue == LuckyTwo || DiceValue == LuckyThree)
        {
            Debug.Log("Gewonnen, die Glückszahl war " + DiceValue);
            //Damit die Konsole nicht zugespamt wird, wird DiceValue = 0 gesetzt:
            DiceValue = 0;
        }

    }
}
