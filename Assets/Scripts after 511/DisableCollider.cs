﻿using UnityEngine;
using System.Collections;

public class DisableCollider : MonoBehaviour {
	Collider collider;
	// Use this for initialization
	void Start () {
		collider = GetComponent<Collider> ();
	}

	public void DisableCol() {
		collider.enabled = false;
	}

	public void EnableCol() {
		collider.enabled = true;
	}

	// Update is called once per frame
	void Update () {
	
	}
}
