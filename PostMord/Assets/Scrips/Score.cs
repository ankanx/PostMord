using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Score : MonoBehaviour {

    public float score;
    private float elapsedTime = 0;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {

        score = score + Time.deltaTime * 100;

        //GUI.Label(new Rect(10, 10, 100, 30), "score: " + (int)(score * 100));

        Debug.Log(score);
 
	}
}
