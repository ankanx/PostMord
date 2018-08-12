using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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
    public Text speach;

    public int NumberOfPackagesInWarehouse = 0;
    public int NumberOfIncomingPackages = 1000;
    public int NumberOfOutgoingPackages = 1000;
    public int NumberOfPackagesYouCanStore = 2000;

    // Use this for initialization
    void Start () {
        Time.timeScale = 1;
    }
	
	// Update is called once per frame
	void Update () {
        if ((Score.score > 10) && !LakeActive)
        {
            speach.text = "Hey! i know what, if you feel that it's getting a bit crouded in here just dump some packages in the lake. No one will find out. i Promise";
            ActivateLake();
            LakeActive = true;
            StartCoroutine(Wait(5));
            
        }

        if ((Score.score > 100) && !ForestActive)
        {
            speach.text = "Dude, Theres a forest close by. No one ever enters that place. Just dump some low priority packages there.";
            ActivateForest();
            ForestActive = true;
            StartCoroutine(Wait(5));
        }

        if ((Score.score > 500) && !FactoryActive)
        {
            speach.text = "That Recycling plant needs some more garbage to burn if u know what i mean.";
            ActivateFactory();
            FactoryActive = true;
            StartCoroutine(Wait(5));
        }

        CalculateChanseForAccident();

    }

    IEnumerator Wait(float duration)
    {

        yield return new WaitForSeconds(duration);   //Wait
        speach.text = "";
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
