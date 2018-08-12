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

    public bool UsedLake = false;
    public bool UsedFactory = false;
    public bool UsedForest = false;
    public float ChanseForAccident = 0;



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if ((Score.score > 10) && !LakeActive)
        {
            ActivateLake();
        }

        if ((Score.score > 50) && !ForestActive)
        {
            ActivateForest();
        }

        if ((Score.score > 100) && !FactoryActive)
        {
            ActivateFactory();
        }

        CalculateChanseForAccident();

    }

    public void ActivateFactory()
    {
        Factory.GetComponent<Factory>().Activate();
    }

    public void ActivateForest()
    {
        Forest.GetComponent<Forest>().Activate();
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
