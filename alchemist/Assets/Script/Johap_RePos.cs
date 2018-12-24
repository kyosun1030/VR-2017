using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Johap_RePos : MonoBehaviour {
    public GameObject Mine_Pos;
    public float T = 0;
    public bool change = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(change)
        {
            T += Time.deltaTime;
        }
        if (change && T > 2.0f)
        {
            change = false;
            T = 0;
            this.transform.position = new Vector3(Mine_Pos.transform.position.x, Mine_Pos.transform.position.y, Mine_Pos.transform.position.z);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ground")
        {
            
         
                change = true;
            
           
        }

    }
}
