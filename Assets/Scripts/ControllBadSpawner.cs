using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllBadSpawner : MonoBehaviour {

    public GameObject BadSpawners;
	GameObject[] ChildsOfBad;
	GameObject[] listOfSpawner;
	public int spawCicle;
	int afectedSpawner;
	float timeElapsed;

	void Start () 
	{
		listOfSpawner = new GameObject[5];
		ChildsOfBad = new GameObject[5];
		spawCicle = Random.Range (0, 3);

		for (int i = 0; i < 5; i++) 
		{
			listOfSpawner [i] = BadSpawners.transform.GetChild (i).gameObject;
		} 
	}
	
	void Update () 
	{
		timeElapsed += Time.deltaTime;
		if (timeElapsed > spawCicle) 
		{	

			ObjectPool objectPool = listOfSpawner [afectedSpawner].GetComponent<ObjectPool>();
			objectPool.poolSize = 1;
			afectedSpawner = Random.Range (0, 5);
			desactiveObject (afectedSpawner);
			spawCicle = Random.Range (0, 3);
			timeElapsed = 0;
		}
	}

	void desactiveObject(int afectedSpawner)
	{
		ObjectPool objectPool = listOfSpawner [afectedSpawner].GetComponent<ObjectPool> ();
		objectPool.poolSize = 0;
	}
}
