using UnityEngine;
using System.Collections;

public class DestroyObject : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        StartCoroutine(Del());
    }

    IEnumerator Del()
    {
        yield return new WaitForSeconds(3.0f);
        Destroy(gameObject);
    }
}
