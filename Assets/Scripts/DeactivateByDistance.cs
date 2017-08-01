using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateByDistance : MonoBehaviour
{
	float distance = 0f;

	void Update () 
	{
		distance = Vector3.Distance(transform.parent.position, transform.position);
		if (distance > 95) 
		{
			gameObject.SetActive (false);
			transform.position = transform.parent.position;
		}	
	}
}
