using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	bool gameIsPaused = false;
	public Canvas PauseUI;
	public Canvas InstructionsUI;
    public AudioSource Run;

	void Start() {
		Time.timeScale = 1;
		PauseUI.gameObject.SetActive (false);
		gameIsPaused = false;
	}

	void Update() {
		if (Input.GetKeyDown("p") && (gameIsPaused == false)) {
            Run.Stop();
            Time.timeScale = 0;
            PauseUI.gameObject.SetActive (true);
			gameIsPaused = true;

		} else if (Input.GetKeyDown("p") && (gameIsPaused == true)) {
            Run.Play();
            gameIsPaused = false;
			PauseUI.gameObject.SetActive (false);
			Time.timeScale = 1;
		}
	}

	public void Continue () {
		PauseUI.gameObject.SetActive (false);
		Time.timeScale = 1;
		gameIsPaused = false;
	}

	public void ShowInstructions () {
		InstructionsUI.gameObject.SetActive (true);
	}

	public void CloseInstructions () {
		InstructionsUI.gameObject.SetActive (false);
	}
}


