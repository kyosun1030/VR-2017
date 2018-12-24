using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_ani : MonoBehaviour
{

	public OVRInput.Controller controller;
    public GameObject FireObject;
    public Transform FirePosition;
    public float FirePower;
    Animator ani;
    public GameObject Fire;
	private bool mag = false;
	public string buttonName;

    public GameObject Target;
    public GameObject Target2;

    public GameObject TargetSpawn1;
    public GameObject TargetSpawn2;
    public GameObject TargetSpawn3;
    int i, j, k;
	public AudioClip Sound_1;

    void Start()
    {
        ani = GetComponent<Animator>();
        i = 0; j = 0; k = 0;

    }

    void Update()
    {
        //if (Input.GetMouseButtonDown(0)) //0번 이왼쪽번 튼1번 이오른쪽버 튼
        //{
        //    FireProsses();
        //    ani.SetBool("Fire", true);
        //    Fire.SetActive(true);
        //}
        //if (Input.GetMouseButtonUp(0))
        //{
        //   ani.SetBool("Fire", false);
        //    Fire.SetActive(false);
        //}
        if (!mag && Input.GetAxis(buttonName) == 1.0f)
        {
			AudioSource.PlayClipAtPoint(Sound_1, this.transform.position);
            FireProsses();
            ani.SetBool("Fire", true);
            Fire.SetActive(true);
        }

        if (mag && Input.GetAxis(buttonName) < 1.0f)
        {
            mag = false;
            ani.SetBool("Fire", false);
            Fire.SetActive(false);
        }

        

            i++; j++; k++;
            int u = Random.Range(200, 300);
            int t = Random.Range(250, 350);
            if (i > 250)
            {
                Instantiate(Target, TargetSpawn1.transform.position, Quaternion.identity);
                i = 0;
            }
            if (j > u)
            {
                Instantiate(Target2, TargetSpawn2.transform.position, Quaternion.identity);
                j = 0;
            }
            if (k > t)
            {
                Instantiate(Target2, TargetSpawn3.transform.position, Quaternion.identity);
                k = 0;
            }
        
    }

    void FireProsses()
    {
		mag = true;
        GameObject obj = Instantiate(FireObject) as GameObject;
        obj.transform.position = FirePosition.transform.position;

        Rigidbody rgb = obj.GetComponent<Rigidbody>();
        rgb.velocity = transform.forward * FirePower;

        StartCoroutine(Erase(obj));
    }

    IEnumerator Erase(GameObject obj1)
    {
        yield return new WaitForSeconds(3.0f);

        Destroy(obj1);
    }
}
