using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {

	public Canvas InstructionsUI;
	public Canvas AboutUI;
	public Canvas Config;

	public void openInstructions() 
	{
		InstructionsUI.gameObject.SetActive (true);
	}

	public void closeInstructions() 
	{
		InstructionsUI.gameObject.SetActive(false);
	}

	public void openAbout() 
	{
		AboutUI.gameObject.SetActive (true);
	}

	public void closeAbout() 
	{
		AboutUI.gameObject.SetActive (false);
	}

	public void openConfig()
	{
		Config.gameObject.SetActive (true);
	}

	public void closeConfig()
	{
		Config.gameObject.SetActive (false);
	}
}
