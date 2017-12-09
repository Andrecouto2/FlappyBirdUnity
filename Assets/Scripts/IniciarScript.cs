using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IniciarScript : MonoBehaviour {

	void Start() {
		FlappyBirdScript.inGame = false;
	}

	void Update () {

		// Inicia o game
		if (Input.GetKey (KeyCode.Return) || Input.touchCount == 2) {
			PrincipalScript.pontos = 0;
			SceneManager.LoadScene ("game");
		}
		
	}
}
