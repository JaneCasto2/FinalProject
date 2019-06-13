using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    public float Speed;
    public float RunningSpeed = 2;
    public float NormalSpeed = 1;
    public bool isRunning;


    // Update is called once per frame
    void Update() {

        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;

        transform.Rotate(0, x, 0);

     
    }
}
