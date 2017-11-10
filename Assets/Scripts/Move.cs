using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour 
{
	int speed;
	protected Vector3 movement;
	bool gameIsPaused;

	void Update ()
	{
		speed = Random.Range (1,23);

		if (Time.timeScale != 0) 
		{
			movement = Vector3.left * (speed / 10) * speed * Time.fixedDeltaTime;
			transform.Translate (movement, Space.World);
		}

	}

}
