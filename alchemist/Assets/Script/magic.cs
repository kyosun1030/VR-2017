using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magic : MonoBehaviour
{
    public OVRInput.Controller controller;
    //private bool grabbing;
    //public GameObject fire;
    public Transform WandTransform;
    private bool mag;
    public ParticleSystem flame;
    public GameObject Partic;

    private GameObject magia;
    public string buttonName = "MainTrigger";

    public Rigidbody fireball;
    private Rigidbody fireballInstance;

    // Use this for initialization

    void Awake()
    {
        //    this.enabled = true;
        //    GameObject.FindGameObjectWithTag("wand");
        //   // grabbing = true;

        //    magia = fire;
        Partic.SetActive(false);

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //if (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger))
        //{
        //    StartCoroutine("magi");
        //}
		/*
        if (Input.GetButtonDown("Fire1"))
        {


            StartCoroutine("magi");

        }

        if (Input.GetButtonUp("Fire1"))
        {

            StartCoroutine("shoot");
        }
        */


        if (!mag&&Input.GetAxis(buttonName) == 1)
        {

            StartCoroutine("magi");
        }

        if (mag&&Input.GetAxis(buttonName) < 1)
        {
            Debug.Log("발사");
            StartCoroutine("shoot");
        }

    }

    IEnumerator magi()
    {
        mag = true;
        Partic.SetActive(true);

        //fireballInstance = Instantiate(fireball, WandTransform.position, WandTransform.rotation) as Rigidbody;
        Debug.Log("실행중");
        yield return null;

    }

    IEnumerator shoot()
    {
        mag = false;
        Partic.SetActive(false);
        fireballInstance = Instantiate(fireball, WandTransform.position, WandTransform.rotation) as Rigidbody;
        fireballInstance.AddForce(WandTransform.forward * -1000);
        yield return null;
    }
}
