using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Forest : MonoBehaviour {

    public GameControllerScript gamecontroller;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Activate()
    {
        gameObject.GetComponent<Button>().enabled = true;

    }

    public void Use()
    {
        if (!gamecontroller.UsedForest)
        {
            gamecontroller.UsedForest = true;
            gamecontroller.ChanseForAccident += 10; 
        }
    }
}
