using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mainmenu : MonoBehaviour {

    public GameObject mainmenu;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            mainmenu.active = !mainmenu.active;
            if (Time.timeScale == 1)
                Time.timeScale = 0;
            else
                Time.timeScale = 1;
        }
	}

    public void Resume()
    {
        mainmenu.active = !mainmenu.active;

            Time.timeScale = 1;
    }
}
