using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour {

	public GameObject[] objectList;
	public GameObject objectToPool;
	public int poolSize;

	float timeElapsed = 0f;
	float spawnCycle = Random.Range(1, 4);

	void Start () 
	{
		Vector3 position = transform.position;

		objectList = new GameObject[poolSize];
		for (int i = 0; i < poolSize; i++) 
		{
			objectList [i] = Instantiate (objectToPool);
			objectList [i].transform.parent = gameObject.transform;
			objectList [i].transform.position = position;
			objectList [i].SetActive (false);
		}
	}

	void Update () 
	{	
		timeElapsed += Time.deltaTime;
		if (timeElapsed > spawnCycle) {
			activateObject ();
			spawnCycle = Random.Range(1,4);
			timeElapsed = 0;
		}
	}

	public void activateObject() 
	{
		for (int i = 0; i < poolSize; i++) 
		{
			if (!objectList [i].activeInHierarchy) 
			{
				objectList [i].SetActive (true);
				return;
			}
		}
	}
}
