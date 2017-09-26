using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralSpeed : MonoBehaviour 
{
	public int speed;
	protected Vector3 movement;
	bool gameIsPaused = false;

	void Update ()
	{
		if (Input.GetKeyDown ("p") && (gameIsPaused == false)) {
			Time.timeScale = 0;
			gameIsPaused = true;
		} else if (Input.GetKeyDown ("p") && (gameIsPaused == true)) {
			gameIsPaused = false;
			Time.timeScale = 1;
		} else if (gameIsPaused == false) {
			movement = Vector3.left * (speed / 10) * speed * Time.fixedDeltaTime;
			transform.Translate (movement, Space.World);	
		}
	}
}
