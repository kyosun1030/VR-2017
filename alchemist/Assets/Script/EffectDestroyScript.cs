using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectDestroyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine("DestroyEffect");
        
    }
	
    IEnumerator DestroyEffect()
    {
        
        yield return new WaitForSeconds(1.0f);
        Destroy(gameObject);
        
    }
}
