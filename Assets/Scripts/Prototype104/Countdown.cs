using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Countdown : MonoBehaviour
{
    private bool _canStart;
    public int countdown;

    void Start() 
    {
        _canStart = true;
    }

    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.C) && _canStart)
        {
            StartCoroutine(Countingdown());
        }
        else if (Input.GetKeyDown(KeyCode.C) && !_canStart)
        {
            Debug.Log("Wait for Coroutine to be ready again!");
        }
    }

    //coroutine countdown to test
    private IEnumerator Countingdown()
    {
        _canStart = false;
        Debug.Log("Waiting for seconds of countdown: " + countdown);

        yield return new WaitForSeconds(countdown);

        /* int i = countdown;
        for (; i > 0; i--)
        { 
            Debug.Log("Ready in " + i);

            yield return new WaitForSeconds(1f);

            yield return null;
        } */

        _canStart = true;
    }
}
