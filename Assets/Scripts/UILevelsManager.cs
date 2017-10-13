using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILevelsManager : MonoBehaviour {

	public bool gameIsPaused = false;
	public Canvas InstructionsUI;
	public Canvas PauseUI;
	public Canvas GameOverUI;
	public Canvas LevelCompletUI;

	void Start() 
	{
		Time.timeScale = 0;
	}

	public void CloseInstructions () 
	{
		InstructionsUI.gameObject.SetActive (false);
		Time.timeScale = 1;
	}

	public void OpenPauseUI()
	{
		gameIsPaused = true;
		Time.timeScale = 0;
		PauseUI.gameObject.SetActive (true);
	}

	public void ClosePauseUI()
	{
		gameIsPaused = false;
		Time.timeScale = 1;
		PauseUI.gameObject.SetActive (false);
	}

	public void OpenGameOverUI()
	{
		Time.timeScale = 0;
		GameOverUI.gameObject.SetActive (true);
	}

	public void OpenLevelCompleteUI()
	{
		Time.timeScale = 0;
		LevelCompletUI.gameObject.SetActive (true);
	}
}
