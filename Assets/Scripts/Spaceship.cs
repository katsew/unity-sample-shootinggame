﻿using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Spaceship : MonoBehaviour {

	public float speed;
	public float shotDelay;
	public GameObject bullet;

	public bool canShot;

	public GameObject explosion;

	public void Explosion ()
	{
		Instantiate (explosion, transform.position, transform.rotation);
	}

	public void Shot (Transform origin)
	{
		Instantiate (bullet, origin.transform.position, origin.transform.rotation);
	}

}
