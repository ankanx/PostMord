using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScript : MonoBehaviour {


    public GameObject Forest;
    public GameObject Lake;
    public GameObject Factory;
    public Score Score;
    private bool LakeActive = false;
    private bool FactoryActive = false;
    private bool ForestActive = false;

    private bool UsedLake = false;
    private bool UsedFactory = false;
    private bool UsedForest = false;
    public float ChanseForAccident = 0;



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if ((Score.score > 1000) && !LakeActive)
        {
            ActivateLake();
        }

        if ((Score.score > 10000) && !ForestActive)
        {
            ActivateLake();
        }

        if ((Score.score > 100000) && !FactoryActive)
        {
            ActivateLake();
        }

        CalculateChanseForAccident();

    }

    public void ActivateFactory()
    {
        Factory.GetComponent<Factory>().Activate();
    }

    public void ActivateForest()
    {
        Forest.GetComponent<Factory>().Activate();
    }

    public void ActivateLake()
    {
        Lake.GetComponent<Lake>().Activate();
    }

    public void CalculateChanseForAccident()
    {
        if(Random.Range(0, 100) < ChanseForAccident)
        {
            Accident();
        }
    }

    public void Accident()
    {
        
        switch(Random.Range(0, 5))
        {
            case 0:
                if (UsedFactory)
                {

                }
                break;
            case 1:
                if (UsedForest)
                {

                }
                break;
            case 2:
                if (UsedLake)
                {

                }
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
        }
    }
}
