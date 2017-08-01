using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateByCollision : MonoBehaviour
{
	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.name == "Player")
		{
			gameObject.SetActive (false);
			transform.position = transform.parent.position;
		}
			
	}
}
