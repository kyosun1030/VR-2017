using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetLeft : MonoBehaviour
{
    public GameObject Particle;
    float speed;
    int i;
    void Start()
    {
        speed = 2.0f;
        i = 0;
    }

    void Update()
    {
        this.transform.Translate(Vector3.right * speed * Time.deltaTime);
        i++;
        if(i > 300)
        {
            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            Instantiate(Particle, this.transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
