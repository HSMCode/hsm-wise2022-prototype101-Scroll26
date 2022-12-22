using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject _player;
    private Rigidbody rb;
    [SerializeField] float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
        // make sure to set the tag "Player" on your player character for this to work
        _player = GameObject.FindWithTag("Player");
    }
    
    void FixedUpdate()
    {
        // move the enemy to the vector position of the player
        rb.AddForce((_player.transform.position - transform.position).normalized * speed);
        // Debug.Log("Player: " + player.transform.position + "Enemy: " + transform.position);
    }
    
    
    // For debugging we can add gizmos to help visualise depth and distance a bit better
    void OnDrawGizmosSelected()
    {
        if (_player != null)
        {
            // Draws a blue line from this transform to the target
            Gizmos.color = Color.blue;
            Gizmos.DrawLine(transform.position, _player.transform.position);
        }
    }
}
