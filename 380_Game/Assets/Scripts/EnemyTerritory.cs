﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTerritory : MonoBehaviour {


	private GameObject player;
	private bool playerInTerritory;

	private KnightEnemy knightEnemy;
	private 

	void Awake(){
		knightEnemy = GetComponent<KnightEnemy> ();
	}
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		playerInTerritory = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (playerInTerritory == true)
			knightEnemy.MoveToPlayer ();
		if (playerInTerritory == false)
			knightEnemy.Rest ();
	}

	void OnTriggerEnter2D(Collider2D collider){
		if (collider.gameObject == player) {
			//basicEnemy.Move = new Vector2(1,0);
			playerInTerritory = true;
			Debug.Log ("In the knight's area!");
		}
	}

	void OnTriggerExit2D(Collider2D collider){
		if (collider.gameObject == player) {
			//basicEnemy.Move = new Vector2(0,0);
			playerInTerritory = false;
			Debug.Log ("Out of the knight's area!");
		}
	}
}
