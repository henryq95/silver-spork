﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigSlimeHealth : MonoBehaviour {
	[SerializeField]
	private int health;
	[SerializeField]
	private GameObject slimePrefab;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (health <= 0) {
			for (int i = 0; i < 2; i++) {
				Instantiate (slimePrefab, this.transform.position + new Vector3(i*.2f, 0, 0), Quaternion.identity);
			}
			Destroy (this.gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "Bullet")
			health -= 10;
	}
}
