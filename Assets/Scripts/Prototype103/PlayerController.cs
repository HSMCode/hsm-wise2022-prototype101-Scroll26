using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float forwardInput;
    public float speed;
    public float turnSpeed;
    public Vector3 force;
    private bool isOnGround;

    private Animator _playerAnim;
    private Rigidbody _playerRB;

    // Start is called before the first frame update
    void Start()
    {
        _playerAnim = GetComponent<Animator>();
        _playerRB = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * forwardInput * Time.deltaTime * speed);
        transform.Rotate(Vector3.up * horizontalInput * Time.deltaTime * turnSpeed);

        _playerAnim.SetFloat("Run", forwardInput);

        if (forwardInput != 0 || horizontalInput != 0)
        {
            _playerAnim.SetBool("Walk", true);
        }
        else
        {
            _playerAnim.SetBool("Walk", false);   
        }

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            _playerRB.AddForce(force, ForceMode.Impulse);
            _playerAnim.SetTrigger("Jump");
            isOnGround = false;
            _playerAnim.SetBool("Grounded", false);
        }
    }

    private void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            _playerAnim.SetBool("Grounded", true);
        }
    }

    /* private void OnTriggerEnter (Collider other)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            _playerAnim.SetBool("Grounded", true);
        }
    } */
}
