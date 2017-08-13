using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSave : MonoBehaviour {
	public GameObject PadlockFase2;
	public GameObject SceneFase2;
	public GameObject PadlockFase3;
	public GameObject SceneFase3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(PlayerPrefs.HasKey("Level 1 Farmacia")){
			PadlockFase2.gameObject.SetActive (false);
			SceneFase2.gameObject.SetActive (true);
		}

		if(PlayerPrefs.HasKey("Level 2 Supermercado")){
			PadlockFase3.gameObject.SetActive (false);
			SceneFase3.gameObject.SetActive (true);
		}
	}
}
