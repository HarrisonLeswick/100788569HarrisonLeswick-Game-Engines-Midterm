using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{


    //Player jump
    Rigidbody rb;
    private float distanceToGround;
    private float jumpForce = 750;
    private bool isGrounded = true;

    public int movementspeed = 10;
    // Use this for initialization
    void awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
  
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.forward * movementspeed * Time.deltaTime);
            // Debug.log("Moved Right");
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.back * movementspeed * Time.deltaTime);
            // Debug.log("Moved Left");
        }
        if ( Input.GetKey(KeyCode.Space) && isGrounded)
        {
            transform.Translate(Vector3.up * jumpForce * Time.deltaTime);
            isGrounded = false;
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Ground")
        {
            isGrounded = true;
        }
    }

}
