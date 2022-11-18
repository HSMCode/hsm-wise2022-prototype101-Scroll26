using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDecoy : MonoBehaviour
{
    public GameObject Roboter;
    private int RandomNumber;

    private void Start()
    {
        Invoke("SpawnDecoy", 0.0f);

    }

    private void SpawnDecoy()
    {
        //RandomNumber = Random.Range(1, 51);

        transform.position =transform.position + new Vector3(Random.Range(-5, 5), 1.1f,Random.Range(-5, 5));

        //gameObject.SetActive(true);
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
