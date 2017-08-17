using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gauge : MonoBehaviour {
	public float scaleAnimationWidth;
	public int scaleAnimationSpeed;
	public Slider slider;

	void Start () {
		scaleAnimationWidth = slider.value;
	}
	
	// Update is called once per frame
	void Update () {
		Nobitidimi();
	}

	void Nobitidimi(){
		slider.value = slider.value + 0.1f * Mathf.Sin(Time.frameCount * 5 * 0.01f);
	}
}
