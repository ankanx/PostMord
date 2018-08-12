using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Scoreboard : MonoBehaviour {

    public Save save;

	// Use this for initialization
	void Start () {

        foreach (List<string> s in save.scoreList.score)
        {

            gameObject.GetComponent<Text>().text = gameObject.GetComponent<Text>().text + s[0] + ": " + s[1] + "\n";
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
