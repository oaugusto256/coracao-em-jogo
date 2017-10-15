using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllVolume : MonoBehaviour {

	public AudioSource mscSound;
	public AudioSource btnGreen;
	public AudioSource btnRed;

	void Start ()
	{
		if (PlayerPrefs.HasKey ("btnValue")) 
		{
			btnGreen.volume = PlayerPrefs.GetFloat ("btnValue");
			btnRed.volume = PlayerPrefs.GetFloat ("btnValue");
		}

		if (PlayerPrefs.HasKey ("mscValue")) 
		{
			mscSound.volume = PlayerPrefs.GetFloat ("mscValue");
		}
	}
}
