using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyBirdScript : MonoBehaviour {

	public float impulso;
	// Acessivel a todas as classes
	public static bool inGame;
	// componentes
	Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		// instancias dos componentes
		rb = GetComponent<Rigidbody2D> ();

		// desabilita a gravidade enquanto o jogo nao tem inicio
		rb.gravityScale = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {

		// Habilita gravidade 
		if (!inGame && Input.GetButtonDown ("Fire1")) {
			inGame = true;
			rb.gravityScale = 1.0f;
		} else if (inGame && Input.GetButtonDown ("Fire1")) {
			rb.velocity = new Vector2 (0.0f, impulso);
		}

		// Input para voar

	}

	// Detecta colisao com trigger
	void OnTriggerEnter2D(Collider2D c) {
		PrincipalScript.pontos++;
		print (PrincipalScript.pontos);
	}

	void OnCollisionEnter2D(Collision2D c){
		SceneManager.LoadScene ("start");
	}
}
