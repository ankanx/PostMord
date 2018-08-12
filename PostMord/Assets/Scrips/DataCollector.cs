using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class DataCollector : MonoBehaviour {

    public List<List<string>> score;

    public DataCollector()
    {
        score  = new List<List<string>>();
    }

    public void AddScore(string nameStr, string scoreInt)
    {
        List<string> scoreInternal = new List<string>();
        scoreInternal.Add(nameStr);
        scoreInternal.Add(scoreInt);
        score.Add(scoreInternal);
    }

    // Use this for initialization
    void Start() {
     }
	
	// Update is called once per frame
	void Update () {
		
	}
}
