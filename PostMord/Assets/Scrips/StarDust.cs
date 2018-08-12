using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarDust : MonoBehaviour
{
    public GameObject thisObj;
    public GameObject starDust;
    public int gridX;
    public int gridY;
    public int spacing;

    void Start()
    {
        float startIn = 1;
        float every = 2;
        InvokeRepeating("spawn", startIn, every);
        Debug.Log("Starting");
    }


    void spawn()
    {
        Debug.Log("dust");
        for (var y = 0; y < gridY; y++)
        {
            for (var x = 0; x < gridX; x++)
            { 
                float randomX = Random.Range(-500.0f, 500.0f);
                float randomY = Random.Range(thisObj.transform.position.y, thisObj.transform.position.y + 200);

                var pos = new Vector2(thisObj.transform.position.x + randomX , thisObj.transform.position.y + randomX);
                var myNewSmoke = Instantiate(starDust,pos , Quaternion.identity);
                myNewSmoke.transform.parent = gameObject.transform;
            }
        }
    
        
    }
}