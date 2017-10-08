using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour {

	public Text TimerUI;
	public Text TotalPoints;
	public Text TotalTime;
	public Text PointsUI;
	public Text TimeUI;
	public Text ExceedTimeUI;
	public Canvas GameOverUI;
	float timer = 0f;
	public string TimeValue;
	public string timeString;
	
	// Update is called once per frame
	void Update () 
	{
		timer += Time.deltaTime;

		int seconds = (int)(timer % 60);
		int minutes = (int)(timer / 60) % 60;

		timeString = string.Format ("{0:0}:{1:00}", minutes, seconds);

		TimerUI.text = "Tempo: " + timeString; 

		if (TimeValue == timeString) 
		{
			Time.timeScale = 0;
			TotalPoints.gameObject.SetActive (false);
			TotalTime.gameObject.SetActive (false);
			PointsUI.gameObject.SetActive (false);
			TimeUI.gameObject.SetActive (false);
			ExceedTimeUI.text = "TEMPO EXCEDIDO: " + TimeValue;
			ExceedTimeUI.gameObject.SetActive (true);
			GameOverUI.gameObject.SetActive (true);
		}
	}
}
