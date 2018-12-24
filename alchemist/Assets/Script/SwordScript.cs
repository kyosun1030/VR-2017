using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordScript : MonoBehaviour {

    public GameObject BallEffect;
    public GameObject Missile;
    public GameObject MissileSpawn;
    int interval = 0;
	public AudioClip Sound_1;
    // Use this for initialization
    void Start () {
        interval = 0;
    }
	
	// Update is called once per frame
	void Update () {

        
            interval++;
            if (interval > 150)
            {
                Instantiate(Missile, MissileSpawn.transform.position, Quaternion.identity);
                interval = 0;
            }
        


    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ball")
        {
			AudioSource.PlayClipAtPoint(Sound_1, this.transform.position);
            Instantiate(BallEffect,other.gameObject.transform.position, Quaternion.identity);
            Destroy(other.gameObject);
        }
    }
}
