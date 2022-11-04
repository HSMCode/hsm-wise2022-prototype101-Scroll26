using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TryVariables : MonoBehaviour
{
    public int numberOne = 1;
    public int numberTwo = 2;
    public int numberThree = 3;
    public int numberFour = 4;
    public int numberFive = 5;

    public int result;

    public string Ergebnis = "Ergebnis: ";

    // Start is called before the first frame update
    void Start()
    {
        result = (numberOne + numberTwo + numberThree + numberFour + numberFive) / 3;
        Debug.Log(Ergebnis + result);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
