using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadSave : MonoBehaviour {
	public Text TimeLevel1;
	public Text PointsLevel1;
	public Text TimeLevel2;
	public Text PointsLevel2;
	public Text TimeLevel3;
	public Text PointsLevel3;
	public GameObject PadlockFase2;
	public GameObject SceneFase2;
	public GameObject PadlockFase3;
	public GameObject SceneFase3;

	void Start () 
	{
		
	}
	
	void Update () 
	{
		if (PlayerPrefs.HasKey ("TimeLevel1") && PlayerPrefs.HasKey ("PointsLevel1")) 
		{
			TimeLevel1.text = "TEMPO: " + PlayerPrefs.GetString ("TimeLevel1");
			PointsLevel1.text = "PONTOS: " + PlayerPrefs.GetInt ("PointsLevel1");
		}

		if (PlayerPrefs.HasKey ("TimeLevel2") && PlayerPrefs.HasKey ("PointsLevel2")) 
		{
			TimeLevel2.text = "TEMPO: " + PlayerPrefs.GetString ("TimeLevel2");
			PointsLevel2.text = "PONTOS: " + PlayerPrefs.GetInt ("PointsLevel2");
		}

		if (PlayerPrefs.HasKey ("TimeLevel3") && PlayerPrefs.HasKey ("PointsLevel3")) 
		{
			TimeLevel3.text = "TEMPO: " + PlayerPrefs.GetString ("TimeLevel3");
			PointsLevel3.text = "PONTOS: " + PlayerPrefs.GetInt ("PointsLevel3");
		}

		if(PlayerPrefs.HasKey("Level 1 Farmacia"))
		{
			PadlockFase2.gameObject.SetActive (false);
			SceneFase2.gameObject.SetActive (true);
		}

		if(PlayerPrefs.HasKey("Level 2 Supermercado")){
			PadlockFase3.gameObject.SetActive (false);
			SceneFase3.gameObject.SetActive (true);
		}
	}
}
