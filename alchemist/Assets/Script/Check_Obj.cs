using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check_Obj : MonoBehaviour {

    public GameObject Sink_Point;

    public Vector3 Arrow;
    public bool Check = false;
    public float speed;
    public GameObject Target;
    void Start () {
		
	}
	
	
	void Update () {
		if(Check)
        {
            Arrow = Sink_Point.transform.position - Target.transform.position;

            if ((Target.transform.position - Sink_Point.transform.position).magnitude > 0.2f)
            {
                Target.transform.position += Arrow.normalized * Time.deltaTime * speed;
            }
        }
	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("ㅅㅂ");
        if (other.tag == "Johab")
        {
            Check = true;
            Target = other.gameObject;
          
        }
        //if(other.tag == "Johab")
        //{
        //    other.transform.position = Sink_Point.transform.position;
        //}

    }
    //void OnTriggerExit(Collider other)
    //{
    //    if (other.tag == "Johab")
    //    {
          
    //    }

    //}
}
