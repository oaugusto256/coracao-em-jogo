using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsBtns : MonoBehaviour {

	public AudioSource buttonGreen;
	public AudioSource buttonRed;

	public void clickButtonGreen()
	{
		buttonGreen.Play ();
	}

	public void clickButtonRed()
	{
		buttonRed.Play ();
	}
}
