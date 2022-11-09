using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDecoy : MonoBehaviour
{
    public GameObject Roboter;

    private void OnTriggerEnter(Collider other) 
    {
        Debug.Log(other.name + " triggered into " + gameObject.name);
        Destroy(this.gameObject);

    }
}
