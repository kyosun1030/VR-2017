using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileScript2 : MonoBehaviour {

    //public GameObject targetPos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = Vector3.MoveTowards(transform.position, new Vector3(11.486f, 2.077f, -13.495f), 10.0f * Time.deltaTime);

		if(this.transform.position == new Vector3(11.486f, 2.077f, -13.495f))
			{
			Destroy (this.gameObject);
			}
	}
}
