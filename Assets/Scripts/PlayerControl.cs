using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	public GameObject lastRightRoad;
	public GameObject lastLeftRoad;

	public float step = 20f;
	public float lineWidth = 3f;

	bool lastLeft = false;
	bool lastRight = false;

	bool stepLeft;
	bool stepRight;

	void Update () {

		transform.localScale = new Vector3 (0.1f, 0.1f, 0.1f);
		transform.localRotation = Quaternion.Euler(0.0f, -180.0f, 0.0f);
		transform.position = new Vector3(-12.17f, -3.4f, transform.position.z);

		if (Time.timeScale != 0) 
		{
			if (Input.GetKeyDown (KeyCode.RightArrow)) 
			{
				if (!lastRight)
					moveRight (step);
			}
			if (Input.GetKeyDown (KeyCode.LeftArrow)) 
			{
				if (!lastLeft)
					moveLeft (step);
			}

			if (stepLeft == true) 
			{
				stepLeft = false;
				if (!lastLeft)
					moveLeft (step);
			}

			if (stepRight == true) 
			{
				stepRight = false;
				if (!lastRight)
					moveRight (step);
			}
		}
	}
		
	public void moveRight (float step)
	{
		lastLeft = false;
		transform.position = Vector3.MoveTowards(transform.position, transform.position - Vector3.forward * lineWidth, step);

	}

	public void moveLeft (float step)
	{
		lastRight = false;
		transform.position = Vector3.MoveTowards(transform.position, transform.position + Vector3.forward * lineWidth, step);
	}
		
	void OnCollisionEnter(Collision collision)
	{
		transform.position = new Vector3(-12.17f, -3.4f, transform.position.z);
		if (collision.gameObject.name == "Road1") 
		{
			lastLeft = true;
		} else if (collision.gameObject.name == "Road5") 
		{
			lastRight = true;
		}
	}

	public void moveLeftTouch()
	{
		stepLeft = true;
	}

	public void moveRightTouch()
	{
		stepRight = true;
	}


}
