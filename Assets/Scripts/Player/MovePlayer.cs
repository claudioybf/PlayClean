using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {

	private Rigidbody2D rigidiBody2d;
	private Animator animPlayer;

	public float velocidade = 2f;
	// Use this for initialization
	void Start () {

		rigidiBody2d = GetComponent<Rigidbody2D>();
		animPlayer = GetComponentInChildren<Animator>();
	
	}
	
	// Update is called once per frame
	void Update () {
		Moviment ();
	
	}


	private void Moviment (){

		float x = Input.GetAxis ("Horizontal");         
		float y = Input.GetAxis ("Vertical");          
		Vector2 moviment = new Vector2 (x,y);         

		if (moviment != Vector2.zero) {              
		   
			animPlayer.SetBool ("isWalk", true);   
			animPlayer.SetFloat ("input_v", y);
			animPlayer.SetFloat ("input_h", x);

		} else {
			animPlayer.SetBool ("isWalk", false);

		}

		rigidiBody2d.MovePosition (rigidiBody2d.position + moviment * Time.deltaTime * velocidade);
	
	}
}
