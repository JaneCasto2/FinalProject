using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

    public float force;
    private Rigidbody rb;
    public bool grounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "ground" || collision.gameObject.tag == "object")
        {
            grounded = true;
        }
            
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            rb.AddForce(Vector3.up * force); 
            grounded = false;
        }


    }



















        /* public Vector3 jump;
         public float jumpForce = 2.0f;

         public bool isGrounded;
         Rigidbody rb;

         void Start()
         {
             rb = GetComponent<Rigidbody>();
             jump = new Vector3(0.0f, 2.0f, 0.0f);
         }

         void OnCollisionStay()
         {
             isGrounded = true;
         }

         void FixedUpdate()
         {
             if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
             {

                 rb.AddForce(jump * jumpForce, ForceMode.Impulse);
                 isGrounded = false;
             }
         }
         */

    }
