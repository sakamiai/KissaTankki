﻿using UnityEngine;
using System.Collections;

public class AutoDestroy : MonoBehaviour {

	ParticleSystem ps;

	// Use this for initialization
	void Start () {
		ps = GetComponent<ParticleSystem> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (ps && !ps.IsAlive()) {
			Destroy(gameObject);
		}
	}

}
