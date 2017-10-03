using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartControl : MonoBehaviour {

	public GameObject Heart;
	public float velocityBeat;
	public float sizeHeart = 100;
	public float minSizeHeart = 50;
	public float maxSizeHeart = 100;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		sizeHeart = sizeHeart - velocityBeat;
		ControlHeartBeating(sizeHeart);
	}

	void  ControlHeartBeating( float sizeHeart ) {

		if (sizeHeart < minSizeHeart) {
			sizeHeart = 50f;
			velocityBeat = velocityBeat * -1f;

		} else if (sizeHeart > maxSizeHeart) {
			sizeHeart = 100f;
			velocityBeat = velocityBeat * -1f; 
		} else {
			
			var teste = Heart.transform  as RectTransform;
			teste.sizeDelta = new Vector2 (sizeHeart, sizeHeart);
		}
	
	}
}
