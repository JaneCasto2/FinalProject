using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    private Rigidbody rb;
    public float speed; 
    public float movScalar;
    public float fastScalar;

  

    // Use this for initialization
    void Start () {

        speed = 2f; 

    }
	

	void Update () {

        transform.Translate(speed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, speed * Input.GetAxis("Vertical") * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {

            speed = 8f;

        }
        else
        {

            speed = 4f; 

        }






       /* if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            {
                rb.AddForce(Vector3.right * fastScalar);
            }
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            {
                rb.AddForce(Vector3.left * fastScalar);
            }
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
            {
                rb.AddForce(Vector3.forward * fastScalar);
            }


        }

    */

        }

    }

