using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // シーン移動に必要

namespace Demo3{ 
	public class Button1 : MonoBehaviour {
		public string nextScene;

		public void Push(){
			ChangeScene();
		}

		void ChangeScene(){
			SceneManager.LoadScene(nextScene);
		}
	}
}
