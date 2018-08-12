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
        InvokeRepeating("CalculateChanseForAccident", 10.0f, 10f);

        speach.text = "Hello! Welcome to PostMord, as our new manager you are responceble for the day to day operations.";
        StartCoroutine(Wait(7));
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

        if ((Score.score > 400) && !FactoryActive)
        {
            speach.text = "That recycling plant needs some more garbage to burn if u know what I mean.";
            ActivateFactory();
            FactoryActive = true;
            StartCoroutine(Wait(7));
        }

        

        if(NumberOfPackagesInWarehouse > NumberOfPackagesYouCanStore)
        {
            Score.caught = true;
        }


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
        Debug.Log("Accident!");
        switch(Random.Range(0, 3))
        {
            case 0:
                if (UsedFactory)
                {
                    speach.text = "Oh god, they found out about the tactical incineration of excess workload. You lose 100 Points";
                    Score.score = Score.score - 100;
                    StartCoroutine(Wait(7));
                }
                break;
            case 1:
                if (UsedForest)
                {
                    speach.text = "Dam Greenpeace has been turning the forest upside down again! You lose 30 Points.";
                    Score.score = Score.score - 30;
                    StartCoroutine(Wait(7));
                }
                break;
            case 2:
                if (UsedLake)
                {
                    speach.text = "Them Dolphins found all your love letters!. You Lose 10 Points";
                    Score.score = Score.score - 10;
                    StartCoroutine(Wait(7));
                }
                break;
            case 3:
                speach.text = "One driver forgot to close the doors!. Packages all over the road! You Lose 10 Points";
                Score.score = Score.score - 10;
                StartCoroutine(Wait(7));
                break;

        }
    }
}
