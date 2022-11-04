using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestVariable : MonoBehaviour
{
    public int numberOne = 1;
    public int numberTwo = 2;
    public int result;
    public float numberThree = 1.5f;
    public string stringOne = "This is a String";

    // Start is called before the first frame update
    void Start()
    {
    
       // result = numberOne + numberTwo;
       // Debug.Log("Das Resultat: " + result);

       Debug.Log("Das Resultat Eins: " + numberThree);
       Debug.Log("Das Resultat Zwei: " + stringOne);

    }

    // Update is called once per frame
    void Update()
    {
        
        //result += 1;
        //Debug.Log("Das Resultat im Update: " + result);

    }
}
