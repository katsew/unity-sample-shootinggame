﻿using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public int speed = 10;

	public float lifeTime = 5;

	// Use this for initialization
	void Start () {
		rigidbody2D.velocity = transform.up.normalized * speed;

		Destroy (gameObject, lifeTime);
	}

}
