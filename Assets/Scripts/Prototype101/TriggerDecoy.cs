using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDecoy : MonoBehaviour
{
    public GameObject Roboter;
    private int RandomNumber;

    private void Start()
    {

    }

    private void OnTriggerEnter(Collider other) 
    {
        Debug.Log(other.name + " triggered into " + gameObject.name);

        if (other.name == Roboter.name)
        {
            //when roboter collides with decoy
            Debug.Log("Sorry, this was a decoy");
            
            //Destroy(gameObject);

            gameObject.SetActive(false);
        }

    }
}
