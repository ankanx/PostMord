using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Score : MonoBehaviour {

    public float score;
    private float elapsedTime = 0;
    public bool caught = false;
    public GameObject newScore;
    public bool showScore = false;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if (!caught)
        {
            score = score + Time.deltaTime * 5;
        } else if (!showScore)
        {
            ShowScore();
            showScore = true;
        }
        
 
	}

    public void Penalty (float minus)
    {
        score = score - minus;
    }

    public void Bonus (float bonus)
    {
        score = score + bonus;
    }

    public void Caught()
    {
        caught = true;
    }

    public void ShowScore()
    {
        newScore.active = true;
    }
}
