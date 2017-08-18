using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;	// 追加

public class Counter : MonoBehaviour
{
    public Text counterText; // publicで変数宣言するとエディター上でいじれる

    // 最初からある
    // Use this for initialization
    void Start()
    {
        counterText.text = "0";
    }
}
