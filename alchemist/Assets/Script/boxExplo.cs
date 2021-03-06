﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxExplo : MonoBehaviour {
    public GameObject bomb;
    public float power;
    public float radius;
    public float upforec;

    	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void FixedUpdate()
    {

        if (bomb == enabled)
        {
            Invoke("Detonate",0.5f);
        }
    }

    void Detonate()
    {
        Vector3 explosionPosition = bomb.transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPosition, radius);
        foreach(Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();
			if(rb != null && GameObject.FindWithTag("Jumper"))
            {
                rb.AddExplosionForce(power, explosionPosition, radius, upforec, ForceMode.Impulse);
            }
        }
    }
}
