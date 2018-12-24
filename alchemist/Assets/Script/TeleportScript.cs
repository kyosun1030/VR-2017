using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Jumper")
        {
            SceneManager.LoadScene("Myoji");
        }
        if(other.tag == "Space")
        {
            SceneManager.LoadScene("Space");
        }
        if (other.tag == "Play")
        {
            SceneManager.LoadScene("Play");
        }
    }
}
