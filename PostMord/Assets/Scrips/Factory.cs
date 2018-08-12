using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Factory : MonoBehaviour {
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
        if (!gamecontroller.UsedFactory)
        {
            gamecontroller.UsedFactory = true;
            gamecontroller.ChanseForAccident += 20;
        }
    }
}
