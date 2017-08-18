using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Star : MonoBehaviour
{
    public int inputValue = 0;
    private int count = 0;

    public void Push(Text uiText)
    {
        int num = int.Parse(uiText.text);
        uiText.text = (num + inputValue).ToString();
    }

    public void OnMouseDown()
    {
        gameObject.SetActive(false);
        if (count >= 10)
        {
            count = 0;
            gameObject.SetActive(true);
        }
        count ++;
    }
}

