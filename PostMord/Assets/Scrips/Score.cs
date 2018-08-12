using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Score : MonoBehaviour {

    public float score;
    private float elapsedTime = 0;
    private bool caught = false;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if (!caught)
        {
            score = score + Time.deltaTime * 5;
        } else
        {
            ShowScore();
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
        GetComponent<Save>().SaveFile(Mathf.RoundToInt(score));
    }
}
