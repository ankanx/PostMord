﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pulsatingtext : MonoBehaviour
{
    public bool pulse = false;

    void Update()
    {
        if (pulse)
        {
            StartCoroutine(FadeTextToFullAlpha(1f, GetComponent<Text>()));
        }
        else if (!pulse)
        {
            StartCoroutine(FadeTextToZeroAlpha(1f, GetComponent<Text>()));
        }
    }



    public IEnumerator FadeTextToFullAlpha(float t, Text i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
        while (i.color.a < 1.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / t));
            yield return null;
        }
        pulse = false;
    }

    public IEnumerator FadeTextToZeroAlpha(float t, Text i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 1);
        while (i.color.a > 0.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime / t));
            yield return null;
        }
        pulse = true;
    }
    
}
