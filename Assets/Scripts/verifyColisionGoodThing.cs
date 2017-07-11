using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class verifyColisionGoodThing : MonoBehaviour {

    public Canvas OptionScreen;
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "GoodThing")
        {
            OptionScreen.gameObject.SetActive(true);
        }
    }
}
