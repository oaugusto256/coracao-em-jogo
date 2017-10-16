using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILevelsManager : MonoBehaviour {

	bool gameIsPaused = false;
	bool gameIsOver = false;	
	public Canvas InstructionsUI;
	public Canvas PauseUI;
	public Canvas ConfigUI;
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
		if(gameIsOver == false)
		{
			Time.timeScale = 0;
			gameIsPaused = true;
			PauseUI.gameObject.SetActive (true);
		}
	}

	public void ClosePauseUI()
	{
		Time.timeScale = 1;
		gameIsPaused = false;
		PauseUI.gameObject.SetActive (false);
	}

	public void OpenConfigUI()
	{
		if (gameIsPaused == false && gameIsOver == false) 
		{
			Time.timeScale = 0;
			ConfigUI.gameObject.SetActive (true);
		}
	}

	public void CloseConfigUI()
	{
		Time.timeScale = 1;
		ConfigUI.gameObject.SetActive (false);
	}

	public void OpenGameOverUI()
	{
		gameIsOver = true;
		Time.timeScale = 0;
		GameOverUI.gameObject.SetActive (true);
	}

	public void OpenLevelCompleteUI()
	{
		Time.timeScale = 0;
		LevelCompletUI.gameObject.SetActive (true);
	}
}
