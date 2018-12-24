using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disable : MonoBehaviour {
    public GameObject target;
	// Use this for initialization
	void Start () {
        //target = GameObject.FindGameObjectWithTag("Target");
        //if (target.)
     
                

    }

    // Update is called once per frame
    void Update () {
        

        if (Input.GetButtonUp("Fire1"))
        {
            Destroy(gameObject, 5.5f);
        }

    }
}
