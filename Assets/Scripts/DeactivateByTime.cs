using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateByTime : MonoBehaviour
{
	public float lifeTime;
	private float timer;

	void Update ()
	{
		if (Time.time > timer + lifeTime)
		{
			timer = Time.time;
			gameObject.SetActive (false);
			transform.position = transform.parent.position;
		}	
	}
}
