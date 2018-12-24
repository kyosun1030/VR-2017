using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{

    public OVRInput.Controller controller;
    public string buttonName;

    private GameObject grabbedObject;
    public LayerMask grabMask;

    public float grabRadius;
    private bool grabbing;

	public HandChangeScript Hcs;

    private Quaternion lastRotation, currentRotation;

    public GameObject Hand;

    public AudioClip Sound_1;

    void GrabObject()
    {
        grabbing = true;

        RaycastHit[] hits;

        hits = Physics.SphereCastAll(transform.position, grabRadius, transform.forward, 0f, grabMask);


        if (hits.Length > 0)
        {
            int closesHit = 0;

            for (int i = 0; i < hits.Length; i++)
            {
                if (hits[i].distance < hits[closesHit].distance) closesHit = i;
            }
            AudioSource.PlayClipAtPoint(Sound_1, this.transform.position);
            grabbedObject = hits[closesHit].transform.gameObject;
            grabbedObject.GetComponent<Rigidbody>().isKinematic = true;

            VisCircle.PowerUpAnimation anime = grabbedObject.GetComponent<VisCircle.PowerUpAnimation>();
            if (anime != null) anime.enabled = false;
            grabbedObject.transform.position = transform.position;
            grabbedObject.transform.parent = transform;
            Hand.SetActive(false);
        }
    }
    void DropObject()
    {
        grabbing = false;

        if (grabbedObject != null)
        {
            grabbedObject.transform.parent = null;
            grabbedObject.GetComponent<Rigidbody>().isKinematic = false;
            grabbedObject.GetComponent<Rigidbody>().useGravity = true;
            grabbedObject.GetComponent<Rigidbody>().velocity = OVRInput.GetLocalControllerVelocity(controller);
            grabbedObject.GetComponent<Rigidbody>().angularVelocity = GetAngularVelocity();

            grabbedObject = null;
            //Hand.SetActive(true);
        }


    }


    Vector3 GetAngularVelocity()
    {
        Quaternion deltRotation = currentRotation * Quaternion.Inverse(lastRotation);
        return new Vector3(Mathf.DeltaAngle(0, deltRotation.eulerAngles.x), Mathf.DeltaAngle(0, 0), Mathf.DeltaAngle(0, deltRotation.eulerAngles.z));
        //Mathf.DeltaAngle(0, deltRotation.eulerAngles.y)
    }



    // Update is called once per frame
    void Update()
    {

        if (grabbedObject != null)
        {
            lastRotation = currentRotation;
            currentRotation = grabbedObject.transform.rotation;
        }

        //if (!grabbing && Input.GetKeyDown(KeyCode.A)) GrabObject();
        //if (grabbing && Input.GetKeyDown(KeyCode.S)) DropObject();
        if (!grabbing && Input.GetAxis(buttonName) == 1) GrabObject();
        if (grabbing && Input.GetAxis(buttonName) < 1)
        {
			if (!Hcs.Hand_Sward && !Hcs.Hand_Gun && !Hcs.Hand_Wand) 
			{
				Hand.SetActive (true);
				DropObject ();
			}
        }

    }
}