using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActiveByTime : MonoBehaviour {

	float timeElapsed = 0f;

	void Update () {
		timeElapsed += Time.deltaTime;

		if (timeElapsed > 3.0) {
			desactiveObject ();
			timeElapsed = 0;
		}
	}

	public void activeObject() {
		gameObject.SetActive(true);
	}

	public void desactiveObject() {
		gameObject.SetActive(false);
	}
}
