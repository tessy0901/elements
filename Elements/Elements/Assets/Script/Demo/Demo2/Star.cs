using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Demo2{
	public class Star : MonoBehaviour {
		private int countTime;
		public int positionAnimationWidth;
		public int positionAnimationSpeed;
		public int scaleAnimationWidth;
		public int scaleAnimationSpeed;

		void Start () {
			countTime = 0;
		}

		void Update () {
			Yurayura(positionAnimationWidth,positionAnimationSpeed);
			Huwahuwa(scaleAnimationWidth,scaleAnimationSpeed);
		}

		void Yurayura(int width ,int speed){
			transform.position = new Vector3(transform.position.x, width * 0.1f * Mathf.Sin(Time.frameCount * speed * 0.01f), transform.position.z);
		}

		void Huwahuwa(int width ,int speed){
			transform.localScale = new Vector3(transform.localScale.x + width * 0.001f * Mathf.Sin(Time.frameCount * speed * 0.01f), transform.localScale.y + width * 0.001f * Mathf.Sin(Time.frameCount * speed * 0.01f), transform.localScale.z);
		}
	}
}
