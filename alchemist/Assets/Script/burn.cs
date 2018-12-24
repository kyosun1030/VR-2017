using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class burn : MonoBehaviour
{
    public GameObject target;
    //public ParticleSystem Burn;
    public GameObject effect;
    public bool fireburn = false;


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Wall")
        {

            StartCoroutine("burning");
            target.SetActive(false);
        }
    }

    IEnumerator burning()
    {
        Instantiate(effect, gameObject.transform.position, Quaternion.identity);
        fireburn = true;
        yield return null;
    }

}
