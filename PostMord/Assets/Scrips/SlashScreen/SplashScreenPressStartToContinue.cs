using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreenPressStartToContinue : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        if (Input.anyKey)
        {
            SceneManager.LoadScene(1);
        }
    }
}
