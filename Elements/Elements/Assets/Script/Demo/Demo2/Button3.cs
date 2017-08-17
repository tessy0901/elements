using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Demo2{
	public class Button3 : MonoBehaviour {
		public GameObject obj;
		private Vector3 defaultPosition;

		public void Start(){
			defaultPosition = obj.transform.position;
		}

		public void Push(){
			Reset();
		}

		void Reset(){
			obj.transform.position = defaultPosition;
			obj.transform.localScale = new Vector3(1, 1, 1);
		}
	}
}
