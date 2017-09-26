using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralSpawner : MonoBehaviour {

	public GameObject[] objectList;
	public GameObject[] objectsToPool;
	public GameObject Waterbottle;
	public GameObject Testosterone;
	public GameObject objectToPool;
	public int poolSize;
	int spawnCycle;
	float timeElapsed = 0f;


	void Start () 
	{
		Vector3 position = transform.position;

		objectsToPool = new GameObject[2];

		objectsToPool [0] = Waterbottle;
		objectsToPool [1] = Testosterone;

		objectList = new GameObject[poolSize];
		for (int i = 0; i < poolSize; i++) 
		{
			objectList [i] = Instantiate (objectsToPool[Random.Range(0,2)]);
			objectList [i].transform.parent = gameObject.transform;
			objectList [i].transform.position = position;
			objectList [i].SetActive (false);
		}

		spawnCycle = Random.Range(1, 4);
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
				break;
			}
		}
	}
}
