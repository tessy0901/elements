using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;


public class Star : MonoBehaviour
{
    public int inputValue = 0;
    private int count;
    private int start;
    private int now;
    Image image;

    void Start()
    {
        image = GetComponent<Image>();
    }
   
    public void Push(Text uiText)
    {
        if (image.enabled == true)
        {
            int num = int.Parse(uiText.text);
            uiText.text = (num + inputValue).ToString();
        }
    }

    public void OnMouseDown()
    {
        image.enabled = false;
        start = DateTime.Now.Second;
    }

    void Update()
    {
        if (image.enabled == false)
        {
            now = DateTime.Now.Second;
            count = now - start;
            if (count >= 10)
            {
                CountUp();
            }
        }
    }

    void CountUp()
    {
        image.enabled = true;
    }
}