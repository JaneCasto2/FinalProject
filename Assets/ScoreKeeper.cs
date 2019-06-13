using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour {

    public static ScoreKeeper instance;

    public Text txt;
    private int score;

    private void Awake()
    {
        instance = this;
    }

    // Use this for initialization
    void Start () {
        txt = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        txt.text = "Score: " + score.ToString();	
	}

    public void AddScore(int score) { this.score += score; }
}
