﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    Rigidbody rigidbody;
	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody>();
        Vector3 ajustedMouvement = transform.TransformDirection(Vector3.forward);
       // rigidbody.AddForce(ajustedMouvement * 1000);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
