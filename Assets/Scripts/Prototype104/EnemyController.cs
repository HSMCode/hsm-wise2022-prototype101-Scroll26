using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject player;
    private Rigidbody rb;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform, Vector3.up);
        transform.eulerAngles = new Vector3(0,transform.eulerAngles.y,0);

        //move in direction of player
        Vector3 direction = player.transform.position - transform.position;
        transform.position += direction * speed * Time.deltaTime;
    }
}
