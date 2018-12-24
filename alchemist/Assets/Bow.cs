using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour
{

    public OVRInput.Controller controller;

    public string buttonName;

    public GameObject Hand;

    public float Distance;

    public bool shot = false;

    public bool charge = false;

    public enum state { Normal = 0, Charge, Shot };

    state bowState = state.Normal;

    public GameObject FireObject;

    public GameObject FirePosition;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Distance = Vector3.Distance(this.transform.position, Hand.transform.position);

        if (Input.GetKeyDown(KeyCode.A))
        {
            bowState = state.Shot;
        }
        if (bowState == state.Normal && Distance < 0.1f)
        {
            Debug.Log(Distance);
            bowState = state.Charge;
        }
        if (bowState == state.Charge)
        {
            Debug.Log("차지다");
            //if (Input.GetAxis(buttonName) == 1.0f)
            //{
            //    bowState = state.Shot;
            //}
            //if (Input.GetKeyDown(KeyCode.A))
            //{
            //    bowState = state.Shot;
            //}
        }
        if (bowState == state.Shot)
        {
            bowState = state.Normal;
            FireProsses();
        }

    }
    void FireProsses()
    {
        GameObject obj = Instantiate(FireObject) as GameObject;
        obj.transform.position = FirePosition.transform.position;
        
        Rigidbody rgb = obj.GetComponent<Rigidbody>();
        rgb.velocity = transform.forward * Distance * 10;
        

        StartCoroutine(Erase(obj));
    }

    IEnumerator Erase(GameObject obj1)
    {
        yield return new WaitForSeconds(3.0f);

        Destroy(obj1);
    }
}

