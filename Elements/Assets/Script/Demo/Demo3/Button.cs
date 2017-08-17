using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // シーン移動に必要

namespace Demo3{ 
	public class Button : MonoBehaviour {
		public Scene nextScene;

		public void Push(){
			ChangeScene();
		}

		void ChangeScene(){
			SceneManager.LoadScene("a");
		}
	}
}
