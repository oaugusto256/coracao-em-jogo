using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsBtns : MonoBehaviour {

	public AudioSource soundsButtom;
	public AudioClip buttonGreen;
	public AudioClip buttonRed;

	public void clickButtonGreen()
	{
		StartCoroutine (SoundButtonGreen ());		
	}

	IEnumerator SoundButtonGreen ()
	{
		yield return new WaitForSeconds(0.01f);
		soundsButtom.PlayOneShot(buttonGreen);
	}

	public void clickButtonRed()
	{
		StartCoroutine (SoundButtonRed());
	}

	IEnumerator SoundButtonRed()
	{
		yield return new WaitForSeconds(0.01f);
		soundsButtom.PlayOneShot(buttonRed);
	}
}
