using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DesactiveByCollision : MonoBehaviour {

	public Canvas QuestionScreen;

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.name == "Player") {
			QuestionScreen.gameObject.SetActive (true);
		}
	}

	public void activeObject() {
		gameObject.SetActive (true);
		QuestionScreen.gameObject.SetActive (false);
	}

	public void desactiveObject () {
		gameObject.SetActive (false);
		QuestionScreen.gameObject.SetActive (false);
	}
}
