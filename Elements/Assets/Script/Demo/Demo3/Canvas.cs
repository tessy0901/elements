using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas : MonoBehaviour {
		
	void Start(){
		Debug.Log(GetComponent<Canvas>().worldCamera);
		// GetComponent<Canvas>().RenderCamera;
	}
}
