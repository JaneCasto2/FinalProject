using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseRandomFruit : MonoBehaviour
{

    public GameObject[] fruitPrefabs;


   
    void Start()
    {

    }

   
    void Update()
    {
        //Instantiate() // First Param: GameObject to clone, Second Param: Position to make it at (Vector3), Third Param: Rotation to make it at (Use Quaternion.identity for zero rotation)
        //25
        if (Random.Range(0, 25) < 5)
        {
            switch (Random.Range(0, fruitPrefabs.Length + 1))
            {
                case 0:

                    GameObject spawn = Instantiate(fruitPrefabs[0], new Vector3(transform.position.x + Random.Range(-20, 20), transform.position.y, transform.position.z + Random.Range(-20, 20)), Quaternion.identity);
                    spawn.name = "Apple";
                    break;
                case 1:
                    GameObject create = Instantiate(fruitPrefabs[1], new Vector3(transform.position.x + Random.Range(-20, 20), transform.position.y, transform.position.z + Random.Range(-20, 20)), Quaternion.identity);
                    create.name = "Pear";
                    break;
                case 2:
                   
                    break;
            }
        }
    }
}
  
