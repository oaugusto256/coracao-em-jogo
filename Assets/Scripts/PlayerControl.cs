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

		transform.position = new Vector3(-12.17f, -3.4f, transform.position.z);

		if(Input.GetKeyDown(KeyCode.RightArrow)) {
			if(!lastRight)
				moveRight (step);
		}
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			if(!lastLeft)
				moveLeft (step);
		}

		if (stepLeft == true) {
			if (!lastLeft)
				moveLeft(step);
		}

		if (stepRight == true) {
			if (!lastRight)
				moveRight (step);
		}
	}
		
	public void moveRight (float step) {
		stepRight = false;
		lastLeft = false;
		transform.position = Vector3.MoveTowards(transform.position, transform.position - Vector3.forward * lineWidth, step);

	}

	public void moveLeft (float step){
		stepLeft = false;
		lastRight = false;
		transform.position = Vector3.MoveTowards(transform.position, transform.position + Vector3.forward * lineWidth, step);
	}
		
	void OnCollisionEnter(Collision collision)
	{
		transform.position = new Vector3(-12.17f, -3.4f, transform.position.z);
		if (collision.gameObject.name == "Road1") {
			lastLeft = true;
		} else if (collision.gameObject.name == "Road5") {
			lastRight = true;
		}
	}

	public void moveLeftTouch(){
		stepLeft = true;
	}

	public void moveRightTouch(){
		stepRight = true;
	}


}
