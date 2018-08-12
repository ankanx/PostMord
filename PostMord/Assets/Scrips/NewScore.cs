using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewScore : MonoBehaviour {

    public GameObject save;
    public InputField input;
    public GameObject scoreboard;
    public GameObject enterYourName;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ShowScoreboard ()
    {
        save.GetComponent<Save>().LoadFile();
        save.GetComponent<Save>().SaveFile(input.text, save.GetComponent<Score>().score);

        save.GetComponent<Save>().LoadFile();

        scoreboard.active = true;

        enterYourName.active = false;
    }
}
