using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchHeld : MonoBehaviour {

    PickUpAndHold pickUp;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        pickUp = GetComponent<PickUpAndHold>();
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.L) && pickUp.getHeldFruit() != null)
        {
            float x = Random.Range(8f, 16f);
            float y = 1f + Random.Range(0, 2f);
            float z = Random.Range(-2f, 2f);
            float amplitude = 1000.12f;

            GameObject projectile = pickUp.getHeldFruit();
            projectile.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            projectile.transform.parent = null;
            projectile.GetComponent<Rigidbody>().AddForce(transform.TransformVector(new Vector3(z, y, x).normalized * amplitude));
            pickUp.heldFruit = null;

            projectile.AddComponent<AddScoreOnCollide>();
            PickedUpFruitReporter.instance.SetText("");

        }
    }
}
