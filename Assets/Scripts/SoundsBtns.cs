using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsBtns : MonoBehaviour {

	public AudioSource buttonGreen;
	public AudioSource buttonRed;
	//public AudioSource runSound;
	//public AudioSource hitGoodThingSnd;
	//public AudioSource hitBadThingSnd;
	//public AudioSource gameOverSound;

	public void clickButtonGreen()
	{
		buttonGreen.Play ();
	}

	public void clickButtonRed()
	{
		buttonRed.Play ();
	}

	/*public void run()
	{
		runSound.Play ();
	}

	public void hitGoodThing()
	{
		hitGoodThingSnd.Play ();
	}

	public void hitBadThing()
	{
		hitBadThingSnd.Play ();
	}

	public void gameOver()
	{
		gameOverSound.Play ();
	}*/
}
