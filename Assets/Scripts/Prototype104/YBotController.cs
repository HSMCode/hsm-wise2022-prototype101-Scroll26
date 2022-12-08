using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YBotController : MonoBehaviour
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


    public float jumpHeight;
    public float yLevel;
    private float limit;


    // Start is called before the first frame update
    void Start()
    {
        _playerAnim = GetComponent<Animator>();
        _playerRB = GetComponent<Rigidbody>();

        Physics.gravity *= gravityModifier;

        yLevel = gameObject.transform.position.y;
        
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

        //stop jumping when letting go space or when max jump height is reached
        if (Input.GetKeyUp(KeyCode.Space) || limit < 0)
        {
            /* isJumping = false;
            isFalling = true; */

            if (isJumping)
            {
                isJumping = false;
                isFalling = true;
                
                if(!isJumping)
                {
                    _playerAnim.SetBool("Fall", true);
                }
            }

            /* if(!isJumping)
            {
                _playerAnim.SetBool("Fall", true);
            } */
        }

        //create a limit defined by player position and ground level to set max jump height
        limit = jumpHeight - gameObject.transform.position.y + yLevel;
    }


    void FixedUpdate()
    {
        if(isJumping)
        {
            _playerRB.AddForce(Vector3.up * force, ForceMode.Force);
        }

        /* if (isFalling || isOnGround)
        {
            _playerRB.AddForce(Vector3.down * forceDown * _playerRB.mass);
        } */
    }


    private void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;

            if (isFalling)
            {
                _playerAnim.ResetTrigger("Jump");
                _playerAnim.SetBool("Fall", false);
                isFalling = false;
                
            }

            //set yLevel to new y position -> New ground level
            yLevel = gameObject.transform.position.y;
        }
    }

    /* private void OnCollisionExit(Collision other) 
    {
        isOnGround = false;   
    } */
}
