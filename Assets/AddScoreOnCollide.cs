using UnityEngine;
using System.Collections;

public class AddScoreOnCollide : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("target"))
        {
            ScoreKeeper.instance.AddScore(1);
            Destroy(gameObject);
        }
        if(collision.gameObject.CompareTag("ground"))
        {
            Destroy(gameObject);
        }
    }
}
