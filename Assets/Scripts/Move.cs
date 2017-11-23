using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour 
{
	float speed;
	protected Vector3 movement;
	bool gameIsPaused;

	void Update ()
	{
        // speed = Random.Range (0,20);
        speed = 30;

		if (Time.timeScale != 0) 
		{
			movement = Vector3.left *  speed * Time.deltaTime;
			transform.Translate (movement, Space.World);
		}

	}

}
