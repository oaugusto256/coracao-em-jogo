using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AudioManager : MonoBehaviour {

	static bool AudioBegin = false; 
	void Awake()
	{
		if (!AudioBegin) {
			
			DontDestroyOnLoad (gameObject);
			AudioBegin = true;
		} else {
		
			Destroy (this.gameObject);

		}
	}
	void Update () {
		if(Application.loadedLevelName == "Level 1 Farmacia")
		{
			AudioBegin = false;
			Destroy (this.gameObject);
		}
	}
}