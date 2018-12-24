using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target_ani : MonoBehaviour
{
    public GameObject Target;
    public GameObject P;
    public bool Particle_On = false;
   

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            P.SetActive(true);
            Particle_On = true;
            Target.SetActive(false);
        }

    }
}
