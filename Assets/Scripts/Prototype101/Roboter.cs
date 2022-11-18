using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roboter : MonoBehaviour
{
    public float step = 1f;
    public float turn = 45f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //stepforward
        if (Input.GetKeyDown("w"))
        {
            transform.Translate(0,0,step);
        }

        //stepback
        if (Input.GetKeyDown("s"))
        {
            transform.Translate(0,0,-step);
        }

        //stepright
        if (Input.GetKeyDown("d"))
        {
            transform.Translate(step,0,0);
        }

        //stepleft
        if (Input.GetKeyDown("a"))
        {
            transform.Translate(-step,0,0);
        }

        //turnleft
        if (Input.GetKeyDown("q"))
        {
            transform.Rotate(0,-turn,0);
        }

        //turnright
        if (Input.GetKeyDown("e"))
        {
            transform.Rotate(0,turn,0);
        }

    }
}
