using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow2 : MonoBehaviour
{

    public GameObject player;
    public Transform target;
    public Vector3 offset;


    // Start is called before the first frame update
    void Start()
    {
        //target = player.transform;   
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        transform.LookAt(target);
    }
}
