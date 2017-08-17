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
		} 
	}
	void Update () {
		if(Application.loadedLevelName == "Level 1 Farmacia")
		{
			
			Destroy (this.gameObject);
		}
	}
}