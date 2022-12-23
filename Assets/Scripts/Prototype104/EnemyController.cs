using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject _player;
    private Rigidbody rb;
    [SerializeField] float speed;
    private UpdateScoreTimer _updateScoreTimerScript;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
        // make sure to set the tag "Player" on your player character for this to work
        _player = GameObject.FindWithTag("Player");

        _updateScoreTimerScript = GameObject.Find("UpdateScore").GetComponent<UpdateScoreTimer>();
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

    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _updateScoreTimerScript.destroyedEnemies++;

            Destroy(this.gameObject);

        }
    }
}
