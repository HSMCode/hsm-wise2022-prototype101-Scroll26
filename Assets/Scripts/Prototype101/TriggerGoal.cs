using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerGoal : MonoBehaviour
{
    public GameObject Roboter;
    public AudioSource Win;

    void Start() 
    {
        Win = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other) 
    {
        Debug.Log(other.name + " triggered into " + gameObject.name);

        if (other.name == Roboter.name)
        {
            //when roboter collides with goal
            Debug.Log("Victory");
            Win.Play();
        }
    }

}
