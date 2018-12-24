using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Johab : MonoBehaviour {

    public bool drop_obj = false;
    public float T = 0f;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ground")
        {
            T += Time.deltaTime;
            if (T > 3.0f)
            {
                drop_obj = true;
            }
        }

    }
}
