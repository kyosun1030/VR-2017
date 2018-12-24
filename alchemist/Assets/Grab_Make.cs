using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab_Make : MonoBehaviour {
    public GameObject Hand;

    public Create_Jam CJ;

    public GameObject BlueGem;
    
    public float Distance1;
    public float Distance2;
    public float Distance3;
    public float Distance4;

    public float Inven_Distance1;
    public float Inven_Distance2;
    public float Inven_Distance3;


    public SpriteRenderer SR;

    public JoHabScript JS;

    public GameObject Grab_Particle;

    void Start () {
		
	}
	
	void Update () {
        //Debug.Log(Inven_Distance1);
        //Distance = Vector3.Distance(Hand.transform.position, BlueGem.transform.position);
        //Debug.Log(Distance);
        //Debug.Log(Distance1);

        Distance1 = Vector3.Distance(Hand.transform.position, CJ.BlueJam_Create.transform.position);
        Distance2 = Vector3.Distance(Hand.transform.position, CJ.RedJam_Create.transform.position);
        Distance3 = Vector3.Distance(Hand.transform.position, CJ.YellowJam_Create.transform.position);
        //Distance4 = Vector3.Distance(Hand.transform.position, CJ.GreenJam_Create.transform.position);
        //if (JS.Sward_Inven_On)
        //{
        //    Inven_Distance1 = Vector3.Distance(Hand.transform.position, JS.Sward_Inven.transform.position);
        //}
        //if (JS.Gun_Inven_On)
        //{
        //    Inven_Distance2 = Vector3.Distance(Hand.transform.position, JS.Gun_Inven.transform.position);
        //}
        //if (JS.Wand_Inven_On)
        //{
        //    Inven_Distance3 = Vector3.Distance(Hand.transform.position, JS.Wand_Inven.transform.position);
        //}


        if (Distance1 < 0.1f)
        {
            //SR.enabled = true;
            //SR.transform.position = this.transform.position;
            Grab_Particle.SetActive(true);
			Grab_Particle.transform.position = Hand.transform.position;
        }
        else if (Distance2 < 0.1f)
        {
            //SR.enabled = true;
            //SR.transform.position = this.transform.position;
            Grab_Particle.SetActive(true);
            Grab_Particle.transform.position = Hand.transform.position;
        }
        else if (Distance3 < 0.1f)
        {
            //SR.enabled = true;
            //SR.transform.position = this.transform.position;
            Grab_Particle.SetActive(true);
            Grab_Particle.transform.position = Hand.transform.position;
        }
        //else if (Distance4 < 0.1f)
        //{
        //    //SR.enabled = true;
        //    //SR.transform.position = this.transform.position;
        //    Grab_Particle.SetActive(true);
        //    Grab_Particle.transform.position = this.transform.position;
        //}
      
        //else if(Inven_Distance1 < 0.1f)
        //{
        //    Grab_Particle.SetActive(true);
        //    Grab_Particle.transform.position = this.transform.position;
        //}

        //else if (Inven_Distance2 < 0.1f)
        //{
        //    Grab_Particle.SetActive(true);
        //    Grab_Particle.transform.position = this.transform.position;
        //}

        //else if (Inven_Distance3 < 0.1f)
        //{
        //    Grab_Particle.SetActive(true);
        //    Grab_Particle.transform.position = this.transform.position;
        //}
        else
        {
            //SR.enabled = false;
            Grab_Particle.SetActive(false);
        }
    }
}
