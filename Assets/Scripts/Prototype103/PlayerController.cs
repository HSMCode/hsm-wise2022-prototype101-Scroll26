using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float forwardInput;
    public float speed;
    public float turnSpeed;

    public float force;
    public float forceDown;
    public float gravityModifier;

    public bool isOnGround;
    public bool isJumping;
    public bool isFalling;

    private Animator _playerAnim;
    private Rigidbody _playerRB;

    // Start is called before the first frame update
    void Start()
    {
        _playerAnim = GetComponent<Animator>();
        _playerRB = GetComponent<Rigidbody>();

        Physics.gravity *= gravityModifier;
        
    }

    // Update is called once per frame
    void Update()
    {

        //player is walking and running
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


        //player is jumping
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            isOnGround = false;
            isJumping = true;

            if(isJumping)
            {
                _playerAnim.SetTrigger("Jump");
            }
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            isJumping = false;
            isFalling = true;

            if(!isJumping)
            {
                _playerAnim.SetBool("Fall", true);
            }
        }
    }


    void FixedUpdate()
    {
        if(isJumping)
        {
            _playerRB.AddForce(Vector3.up * force, ForceMode.Force);
        }

        if (isFalling || isOnGround)
        {
            _playerRB.AddForce(Vector3.down * forceDown * _playerRB.mass);
        }
    }


    private void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;

            if (isFalling)
            {
                _playerAnim.SetBool("Fall", false);
                isFalling = false;
                
            }
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
