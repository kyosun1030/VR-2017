using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoHabScript : MonoBehaviour {

    public int JoHabNum;

	public GameObject SwordJohab;
	public GameObject GunJohab;
	public GameObject WandJohab;
	public GameObject JumperJohab;

    //public GameObject JohabEffect;
    //public GameObject JohabEffect1;
    //public GameObject JohabEffect2;
   

    public GameObject Font;
    public bool Font_On = false;


    public HandChangeScript Hcs;
    
    public float T = 0;

    public Create_Jam CJ;

    public GameObject Johab_Particle;

    public int One;

    public int Two;

    public int Three;

    public bool Johap_On = false;

    public GameObject Sward_Recipe;

    public GameObject Gun_Recipe;

    public GameObject Wand_Recipe;

    public GameObject Sward_Inven;

    public GameObject Gun_Inven;

    public GameObject Wand_Inven;


    public AudioClip Sound_1;

    public AudioClip Sound_2;

    public bool Sward_Inven_On = false;

    public bool Gun_Inven_On = false;

    public bool Wand_Inven_On = false;

    // Use this for initialization
    void Start () {
        JoHabNum = 0;
		SwordJohab.SetActive (false);
		GunJohab.SetActive (false);
		WandJohab.SetActive (false);
		JumperJohab.SetActive (false);

    }


    void OnTriggerEnter(Collider other)
    {
		
        if(other.tag == "RedJam")
        {
            Font.SetActive(true);
            Font_On = true;
            AudioSource.PlayClipAtPoint(Sound_1, this.transform.position);

            Destroy(other.gameObject);
            if (One == 0)
            {
                One = 1;
                JoHabNum++;
            }
            else if(Two == 0 && One != 1)
            {
                Two = 1;
                JoHabNum++;
            }
            else if (Three == 0 && Two != 1 && One != 1)
            {
                Three = 1;
                JoHabNum++;
            }
            else
            {
                ;
            }
        }
        if (other.tag == "YellowJam")
        {
            Font.SetActive(true);
            Font_On = true;
            AudioSource.PlayClipAtPoint(Sound_1, this.transform.position);

            Destroy(other.gameObject);
            if (One == 0)
            {
                One = 2;
                JoHabNum++;
            }
            else if (Two == 0 && One != 2)
            {
                Two = 2;
                JoHabNum++;
            }
            else if (Three == 0 && Two != 2 && One != 2)
            {
                Three = 2;
                JoHabNum++;
            }
            else
            {
                ;
            }
        }
        if (other.tag == "BlueJam")
        {
            Font.SetActive(true);
            Font_On = true;
            AudioSource.PlayClipAtPoint(Sound_1, this.transform.position);

            Destroy(other.gameObject);
            if (One == 0)
            {
                One = 3;
                JoHabNum++;
            }
            else if (Two == 0 && One != 3)
            {
                Two = 3;
                JoHabNum++;
            }
            else if (Three == 0 && Two != 3 && One != 3)
            {
                Three = 3;
                JoHabNum++;
            }
            else
            {
                ;
            }
        }


   //     if (other.tag == "Johab")
   //     {
   //         Font.SetActive(true);
   //         Font_On = true;
   //         JoHabNum++;
   //         Destroy(other.gameObject);
			//switch (JoHabNum) {
			//case 4:
			//	    SwordJohab.SetActive (true);
   //                 //Instantiate(JohabEffect, SwordJohab.transform.position, Quaternion.identity);
   //                 //Instantiate(JohabEffect1, SwordJohab.transform.position, Quaternion.identity);
   //                 // Instantiate(JohabEffect2, SwordJohab.transform.position, Quaternion.identity);
   //                 Johap_On = true;
   //                 Hcs.Sward_ON = true;
   //                 break;
                    
               
                                  

			//case 8:
			//	GunJohab.SetActive (true);
   //                 //Instantiate(JohabEffect, SwordJohab.transform.position, Quaternion.identity);
   //                 //Instantiate(JohabEffect1, SwordJohab.transform.position, Quaternion.identity);
   //                 //Instantiate(JohabEffect2, SwordJohab.transform.position, Quaternion.identity);
				
   //                 Johap_On = true;
   //                 Hcs.Gun_ON = true;
   //                 break;
                    

			//case 12:
			//	WandJohab.SetActive (true);
   //                //Instantiate(JohabEffect, SwordJohab.transform.position, Quaternion.identity);
   //                 //Instantiate(JohabEffect1, SwordJohab.transform.position, Quaternion.identity);
   //                 //Instantiate(JohabEffect2, SwordJohab.transform.position, Quaternion.identity);
				
   //                 Johap_On = true;
   //                 Hcs.Wand_ON = true;
   //                 break;

			////case 16:  //점퍼
			////	JumperJohab.SetActive (true);
   ////                //Instantiate(JohabEffect, SwordJohab.transform.position, Quaternion.identity);
   ////                 //Instantiate(JohabEffect1, SwordJohab.transform.position, Quaternion.identity);
   ////                 //Instantiate(JohabEffect2, SwordJohab.transform.position, Quaternion.identity);
				
   ////                 Johap_On = true;
   ////                 break;
			//}
   //     }

    }
    //Red = 1 , Yellow = 2; Blue = 3
	void Update () {
		
        if(JoHabNum == 3)
        {
            if(One == 1 && Two == 3 && Three == 2)
            {
                AudioSource.PlayClipAtPoint(Sound_2, SwordJohab.transform.position);
                SwordJohab.SetActive(true);
                Johap_On = true;
                Hcs.Sward_ON = true;
                Sward_Recipe.SetActive(true);
                Sward_Inven.SetActive(true);
                Sward_Inven_On = true;
            }
            if (One == 1 && Two == 2 && Three == 3)
            {
                AudioSource.PlayClipAtPoint(Sound_2, GunJohab.transform.position);
                GunJohab.SetActive(true);
                Johap_On = true;
                Hcs.Gun_ON = true;
                Gun_Recipe.SetActive(true);
                Gun_Inven.SetActive(true);
                Gun_Inven_On = true;
            }
            if (One == 3 && Two == 1 && Three == 2)
            {
                AudioSource.PlayClipAtPoint(Sound_2, WandJohab.transform.position);
                WandJohab.SetActive(true);
                Johap_On = true;
                Hcs.Wand_ON = true;
                Wand_Recipe.SetActive(true);
                Wand_Inven.SetActive(true);
                Wand_Inven_On = true;
            }
			if(One == 2 && Two == 1 && Three == 3)
			{
                AudioSource.PlayClipAtPoint(Sound_2, this.transform.position);
                Hcs.no_On = true;
				Johap_On = true;
			}
			if (One == 2 && Two == 3 && Three == 1)
			{
                AudioSource.PlayClipAtPoint(Sound_2, this.transform.position);
                Hcs.no_On = true;
				Johap_On = true;

			}
			if (One == 3 && Two == 2 && Three == 1)
			{
                AudioSource.PlayClipAtPoint(Sound_2, this.transform.position);
                Hcs.no_On = true;
				Johap_On = true;
			}
        }
        if (Font_On)
        {
            T += Time.deltaTime;
            if (T > 1.0f)
            {
                Font.SetActive(false);
                Font_On = false;
                T = 0f;
            }
        }

        if (Johap_On)
        {
            Johab_Particle.SetActive(true);
          
        }
        else
        {
            Johab_Particle.SetActive(false);
        }
    }
	void Re_Johab()
	{
		One = 0;
		Two = 0;
		Three = 0;
	}

}
