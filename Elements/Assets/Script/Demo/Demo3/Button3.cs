using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // シーン移動に必要

namespace Demo3{ 
	public class Button3 : MonoBehaviour {
		public string additionalScene;

		public void Push(){
			UnloadScene();
		}

		void UnloadScene(){
			SceneManager.UnloadScene(additionalScene);
		}
	}
}
