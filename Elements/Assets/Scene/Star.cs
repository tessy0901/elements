using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Star : MonoBehaviour
{
    public int inputValue = 0;
    private int count = 0;
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
    }

    void Update()
    {
        if (image.enabled == false)
        {
            if (count >= 60)
            {
                count = 0;
                CountUp();
            }
            count++;
        }
    }

    void CountUp()
    {
        image.enabled = true;
    }
}