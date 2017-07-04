using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class Lixo : MonoBehaviour {
	public static int pontos;
	public int pontoDoLixo;
	public Text lblPontos;
	Stack <object> pilha = new Stack <object> ();



	void OnCollisionEnter2D(Collision2D colisor) {
		
		if (colisor.gameObject.tag == "Player" ) {
			pilha.Push (gameObject);
			Debug.Log ("um lixo foi pego",gameObject);
			pontos += pontoDoLixo;
			lblPontos.text = "Pontos: " + pontos;
			Destroy (gameObject);		
		}
	}
}

