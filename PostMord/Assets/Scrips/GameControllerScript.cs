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
    public int NumberOfIncomingPackages = 100;
    public int NumberOfOutgoingPackages = 1000;
    public int NumberOfPackagesYouCanStore = 5000;

    // Use this for initialization
    void Start () {
        Time.timeScale = 1;
        InvokeRepeating("ReciveShipment", 2.0f, 2f);
        InvokeRepeating("SendShipment", 2.0f, 3f);
    }
	
    public void SendShipment()
    {
        NumberOfPackagesInWarehouse = NumberOfPackagesInWarehouse - NumberOfOutgoingPackages;
        if(NumberOfPackagesInWarehouse < 0)
        {
            NumberOfPackagesInWarehouse = 0;
        }
    }

    public void ReciveShipment()
    {
        NumberOfPackagesInWarehouse = NumberOfPackagesInWarehouse + NumberOfIncomingPackages;
        NumberOfIncomingPackages = NumberOfIncomingPackages +  100;
    }

    // Update is called once per frame
    void Update () {
        if ((Score.score > 50) && !LakeActive)
        {
            speach.text = "Hey! I know what, if you feel that it's getting a bit crowded in here just dump some packages in the lake. No one will find out. I promise.";
            ActivateLake();
            LakeActive = true;
            StartCoroutine(Wait(7));
            
        }

        if ((Score.score > 100) && !ForestActive)
        {
            speach.text = "Dude, There is a forest close by. No one ever enters that place. Just dump some low priority packages there.";
            ActivateForest();
            ForestActive = true;
            StartCoroutine(Wait(7));
        }

        if ((Score.score > 500) && !FactoryActive)
        {
            speach.text = "That recycling plant needs some more garbage to burn if u know what I mean.";
            ActivateFactory();
            FactoryActive = true;
            StartCoroutine(Wait(7));
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
