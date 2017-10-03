using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour 
{
	int speed;
	protected Vector3 movement;
	bool gameIsPaused = false;

	void Update ()
	{
		speed = Random.Range (5,20);

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
