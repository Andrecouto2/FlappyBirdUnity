using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour {

	// Recebe elemento text UI
	public Text txtPontos;

	void Update () {
		//atualiza o placar
		txtPontos.text = PrincipalScript.pontos.ToString();

	}
}
