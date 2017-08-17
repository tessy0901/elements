using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // シーン移動に必要

namespace Demo3{ 
	public class Button2 : MonoBehaviour {
		public string additionalScene;

		public void Push(){
			AdditionScene();
		}

		void AdditionScene(){
			SceneManager.LoadScene(additionalScene,LoadSceneMode.Additive);
		}
	}
}
