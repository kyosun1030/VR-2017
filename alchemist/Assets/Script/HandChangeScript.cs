using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandChangeScript : MonoBehaviour {
    public GameObject Hand;
    public GameObject Sword;
    public GameObject Gun;
    public GameObject Wand;
    public GameObject Teleport;

    public GameObject DestroyCircle;
    public GameObject Picture;

    public JoHabScript Js;

    public bool Sward_ON = false;
    public bool Gun_ON = false;
    public bool Wand_ON = false;
	public bool no_On = false;

	public bool Hand_Sward = false;
	public bool Hand_Gun = false;
	public bool Hand_Wand = false;

    public float T;
    //public GameObject Jumper;
    // Use this for initialization
    void Start () {
        Sword.SetActive(false);
        Gun.SetActive(false);
        Wand.SetActive(false);
        Teleport.SetActive(false);
        Picture.SetActive(false);
    }

    // Update is called once per frame
    void Update () {
        if(Sward_ON)
        {
            T += Time.deltaTime;
            if (T > 3.0f)
            {
				Hand_Sward = true;
                Hand.SetActive(false);
                Sword.SetActive(true);
                Gun.SetActive(false);
                Wand.SetActive(false);
                Js.Johap_On = false;
                Js.SwordJohab.SetActive(false);
                Sward_ON = false;
                T = 0f;
				Re_Johab ();
            }
        }

        if(Gun_ON)
        {
            T += Time.deltaTime;
            if (T > 3.0f)
            {
				Hand_Gun = true;
                Hand.SetActive(false);
                Gun.SetActive(true);
                Wand.SetActive(false);
                Js.Johap_On = false;
                Js.GunJohab.SetActive(false);
                Gun_ON = false;
                T = 0f;
				Re_Johab ();
            }
        }

        if(Wand_ON)
        {
            T += Time.deltaTime;
            if (T > 3.0f)
            {
				Hand_Wand = true;
                Hand.SetActive(false);
                Wand.SetActive(true);
                Gun.SetActive(false);
                Js.WandJohab.SetActive(false);
                Js.Johap_On = false;
                Wand_ON = false;
                T = 0f;
				Re_Johab ();
            }
        }
		if (no_On) 
		{ 
			T += Time.deltaTime;
			if (T > 3.0f) {
				Re_Johab ();
				Js.Johap_On = false;
				no_On = false;
				T = 0f;
			}
		}
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "SwordMagic")
        {
			Hand_Sward = true;
            Hand.SetActive(false);
            Sword.SetActive(true);
            Gun.SetActive(false);
            Wand.SetActive(false);
            Js.Johap_On = false;
           
        }
        if (other.tag == "GunMagic")
        {
			Hand_Gun = true;
            Hand.SetActive(false);
			Sword.SetActive (false);
            Gun.SetActive(true);
            Wand.SetActive(false);
            Js.Johap_On = false;
            
        }
        if (other.tag == "WandMagic")
        {
			Hand_Wand = true;
			Sword.SetActive (false);
            Hand.SetActive(false);
            Wand.SetActive(true);
            Gun.SetActive(false);
			
            Js.Johap_On = false;
        }
        
		if (other.tag == "TeleportMagic")
        {
            Hand.SetActive(false);
            Teleport.SetActive(true);
            DestroyCircle.SetActive(false);
            Picture.SetActive(true);
            Gun.SetActive(false);
            Wand.SetActive(false);
			Destroy (other.gameObject);
            Js.Johap_On = false;
        }
        
            if (other.tag == "DestroyMagic")
        {
            Hand.SetActive(true);
            Sword.SetActive(false);
            Gun.SetActive(false);
            Wand.SetActive(false);
			Sward_ON = false;
			Gun_ON = false;
			Wand_ON = false;
			Hand_Sward = false;
			Hand_Gun = false;
			Hand_Wand = false;
        }
    }

	void Re_Johab()
	{
		Js.JoHabNum = 0;
		Js.One = 0;
		Js.Two = 0;
		Js.Three = 0;
	}
}
