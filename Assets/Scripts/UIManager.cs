using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {

	public GameObject InstructionsUI;
	public GameObject AboutUI;

	public void openInstructions() {
		InstructionsUI.SetActive (true);
	}

	public void closeInstructions() {
		InstructionsUI.SetActive (false);
	}

	public void openAbout() {
		AboutUI.SetActive (true);
	}

	public void closeAbout() {
		AboutUI.SetActive (false);
	}
}
