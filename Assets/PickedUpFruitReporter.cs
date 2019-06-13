using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickedUpFruitReporter : MonoBehaviour {
    public static PickedUpFruitReporter instance;
    public string pickedUp;

    private Text txt;
    private void Awake()
    {
        instance = this;
    }

    // Use this for initialization
    void Start () {
        txt = GetComponent<Text>();
	}

    private void Update()
    {
        txt.text = pickedUp;
    }

    public void SetText(string str)
    {
        pickedUp = str;
    }
}
