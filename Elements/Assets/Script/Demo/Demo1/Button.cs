using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour {
	public int inputValue = 0; 

	public void Push(Text uiText){
		int num = int.Parse(uiText.text);
		uiText.text = (num + inputValue).ToString();
	}
}
