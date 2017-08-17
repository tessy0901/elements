using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Demo2{
	public class Button2 : MonoBehaviour {
		public GameObject obj;

		public void Push(){
			ChangeScale();
		}

		void ChangeScale(){
			obj.transform.localScale = new Vector3(obj.transform.localScale.x + 0.1f, obj.transform.localScale.y + 0.1f, 1);
		}
	}
}
