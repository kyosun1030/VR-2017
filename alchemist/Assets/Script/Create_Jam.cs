using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create_Jam : MonoBehaviour {

    public GameObject RedJam;
    public GameObject BlueJam;
    public GameObject YellowJam;
    public GameObject GreenJam;

    public GameObject RedJam_Create;
    public GameObject BlueJam_Create;
    public GameObject YellowJam_Create;
    public GameObject GreenJam_Create;

    public GameObject RedJam_Pos;
    public GameObject BlueJam_Pos;
    public GameObject YellowJam_Pos;
    public GameObject GreenJam_Pos;

    public GameObject Circle;
    public SpriteRenderer Circle2;

    //public bool Make = false;
    void Start () {
        //Create_Jam_Maked();
        RedJam_Create = Instantiate(RedJam) as GameObject;
        BlueJam_Create = Instantiate(BlueJam) as GameObject;
        YellowJam_Create = Instantiate(YellowJam) as GameObject;
        //GreenJam_Create = Instantiate(GreenJam) as GameObject;

        RedJam_Create.transform.position = RedJam_Pos.transform.position;
        BlueJam_Create.transform.position = BlueJam_Pos.transform.position;
        YellowJam_Create.transform.position = YellowJam_Pos.transform.position;
        //GreenJam_Create.transform.position = GreenJam_Pos.transform.position;

    }
	
	// Update is called once per frame
	void Update () {
        if(!RedJam_Create)
        {
            RedJam_Create = Instantiate(RedJam) as GameObject;
            RedJam_Create.transform.position = RedJam_Pos.transform.position;
        }
        if (!BlueJam_Create)
        {
            BlueJam_Create = Instantiate(BlueJam) as GameObject;
            BlueJam_Create.transform.position = BlueJam_Pos.transform.position;
        }
        if (!YellowJam_Create)
        {
            YellowJam_Create = Instantiate(YellowJam) as GameObject;
            YellowJam_Create.transform.position = YellowJam_Pos.transform.position;
        }
        //if (!GreenJam_Create)
        //{
        //    GreenJam_Create = Instantiate(GreenJam) as GameObject;
        //    GreenJam_Create.transform.position = GreenJam_Pos.transform.position;
        //}
        //if(Input.GetKeyDown(KeyCode.A))
        //{
        //    Circle2.enabled = true;
        //}
        //if (Input.GetKeyDown(KeyCode.S))
        //{
        //    Circle2.enabled = false;
        //}
        //if(Make)
        //      {
        //          Create_Jam_Maked();
        //          Make = false;
        //      }
    }
    //void Create_Jam_Maked()
    //{
    //    //for (int x = 0; x < 4; x++)
    //    //{
    //    //    r = Random.Range(0, 10);
    //    //    GameObject obj = Instantiate(Jam[r]) as GameObject;
    //    //    obj.transform.position = Jam_Pos[x].transform.position;
    //    //}
    //}
    void OnTriggerEnter(Collider other)
    {
        //if(other.tag == "Johab")
        //{
         //   Debug.Log("aldl");
        //    Destroy(other.gameObject);
        //}
		if(other.tag == "RedJam")
		{
			
			Destroy(other.gameObject);
		}
		if(other.tag == "BlueJam")
		{
			
			Destroy(other.gameObject);
		}
		if(other.tag == "YellowJam")
		{
			
			Destroy(other.gameObject);
		}

    }
}
