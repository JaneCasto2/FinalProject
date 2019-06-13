using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpAndHold : MonoBehaviour {

	public GameObject player;
    public bool holding = false;
    public GameObject heldFruit;

    void OnCollisionEnter(Collision col)
    {
        if (heldFruit != null) { return; } 

        if (col.gameObject.name == "Pear" || col.gameObject.name == "Apple")
        {
            col.gameObject.transform.SetParent(GameObject.FindGameObjectWithTag("Player").transform, false);
            col.gameObject.transform.position = player.transform.TransformPoint(new Vector3(0, 0, 1));
            heldFruit = col.gameObject;
            heldFruit.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            PickedUpFruitReporter.instance.SetText(heldFruit.name);
        }
    }


    public GameObject getHeldFruit()
    {
        return heldFruit;
    }
}
