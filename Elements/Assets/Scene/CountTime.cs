using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;	// 追加

public class CountTime : MonoBehaviour
{
    private int countTime = 0;
    public Text counterText; // publicで変数宣言するとエディター上でいじれる

    // 最初からある
    // Use this for initialization
    void Start()
    {
        counterText.text = "0";
    }

    // 最初からある
    // Update is called once per frame
    void Update()
    {
        if (countTime >= 60)
        {
            countTime = 0;
            CountUp();
        }
        countTime++;
    }

    void CountUp()
    {
        int num = int.Parse(counterText.text);
        counterText.text = (num + 1).ToString();
    }
}
