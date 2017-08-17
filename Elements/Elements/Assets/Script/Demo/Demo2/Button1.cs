using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Demo2{
	public class Button1 : MonoBehaviour {
		public GameObject obj;

		public void Push(){
			ChangePosition();
		}

		void ChangePosition(){
			obj.transform.position = new Vector3(0, obj.transform.position.y + 0.1f, 0);
		}
	}
}
