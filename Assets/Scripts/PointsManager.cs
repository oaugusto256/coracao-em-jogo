using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PointsManager : MonoBehaviour {

    bool gameIsPaused = false;
    public Text textPoints;
	public Text timeUI;
    public Text totalPointsUIGOver;
	public Text totalTimeUIGOver;
	public Text totalTimeUILComplete;
	public Text pointsUILComplete;
	public Text bonusTimeUILComplete;
	public Text totalPointsUILComplete;
    public GameObject HealthBar;
	public GameObject Heart;
	public GameObject UIManager;
 	public AudioSource run;
    public AudioSource hitGoodThing;
    public AudioSource hitBadThing;
	public AudioSource gameOver;
	public float curHealth = 0f;
	public int maxHealth = 100;
	public int qntWaterbottle; 
	int countWaterbottle;
	int points;
	int controlFunction;
	string NomeDaFase;

	void Start () 
	{
		curHealth = maxHealth;
		textPoints.text = "Pontos: ";
		points = 0;
		NomeDaFase = SceneManager.GetActiveScene ().name;
		countWaterbottle = 0;
		controlFunction = 1;
	}

	void Update () 
	{
		
		textPoints.text = "Pontos: " + points;
	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.name == "Water(Clone)")
		{
			hitGoodThing.Play ();
			points += 10;
			countWaterbottle += 1;
			controlHeartBeat (countWaterbottle);
		}

		if ( qntWaterbottle == countWaterbottle ) 
		{
			run.Stop ();
			Time.timeScale = 0;
			PlayerPrefs.SetInt(""+NomeDaFase, 1  );
			HeartControl heartControl = Heart.GetComponent<HeartControl> ();
			heartControl.velocityBeat = 0;

			timeUI.gameObject.SetActive (false);
			textPoints.gameObject.SetActive(false);

			UILevelsManager uiManager = UIManager.GetComponent<UILevelsManager> ();
			uiManager.OpenLevelCompleteUI ();

			TimerManager timeManager = UIManager.GetComponent<TimerManager> ();
			totalTimeUILComplete.text = "Tempo: " + timeManager.timeString;
			string timePlayer = timeManager.timeString;

			pointsUILComplete.text = "Pontos: " + points;

			int bonus = calculateBonusTime ();
			bonusTimeUILComplete.text = "Bônus por tempo: x" + bonus;

			int totalPoints = points * bonus;
			totalPointsUILComplete.text = "Total: " + totalPoints;

			saveTimeAndPoints (totalPoints, timePlayer);

		}

		if (collision.gameObject.name == "Testosterone(Clone)") 
		{
			hitBadThing.Play ();
			curHealth -= 20;
            float calcHealth = curHealth / maxHealth;
            setHealthBar(calcHealth);

            if (calcHealth == 0)
            {
				run.Stop ();
				gameOver.Play ();
				Time.timeScale = 0;
				HeartControl heartControl = Heart.GetComponent<HeartControl> ();
				heartControl.velocityBeat = 0;
				timeUI.gameObject.SetActive (false);
                textPoints.gameObject.SetActive(false);
				UILevelsManager uiManager = UIManager.GetComponent<UILevelsManager> ();
				uiManager.OpenGameOverUI ();
                totalPointsUIGOver.text = "Pontos: " + points;
				TimerManager timeManager = UIManager.GetComponent<TimerManager> ();
				totalTimeUIGOver.text = "Tempo: " + timeManager.timeString;
            }
        }        
     }

    public void setHealthBar(float myHealth)
    {
        HealthBar.transform.localScale = new Vector3(myHealth, HealthBar.transform.localScale.y, HealthBar.transform.localScale.z);
    }

	public void controlHeartBeat(int countWaterbottle)
	{
		
		float percentWaterBottle = (countWaterbottle * 100) / qntWaterbottle; 
	
		if ((percentWaterBottle >= 0 && percentWaterBottle <= 25) && controlFunction == 1) {
			HeartControl heartControl = Heart.GetComponent<HeartControl> ();
			heartControl.velocityBeat = 0.6f;
			controlFunction += 1;
		} else if (( percentWaterBottle >= 26 && percentWaterBottle <= 50) && controlFunction == 2) 
		{
			HeartControl heartControl = Heart.GetComponent<HeartControl> ();
			heartControl.velocityBeat = 0.9f;
			controlFunction += 1;
		}else if ((percentWaterBottle >= 51 && percentWaterBottle <= 75) && controlFunction == 3)
		{
			HeartControl heartControl = Heart.GetComponent<HeartControl> ();
			heartControl.velocityBeat = 1.2f;
			controlFunction += 1;
		}else if (percentWaterBottle >= 76 && controlFunction == 4)
		{
			HeartControl heartControl = Heart.GetComponent<HeartControl> ();
			heartControl.velocityBeat = 1.5f;
			controlFunction += 1;
		}
	}

	int calculateBonusTime()
	{
		TimerManager timeManager = UIManager.GetComponent<TimerManager> ();

		string timeString = timeManager.timeString;
		string timeValue = timeManager.TimeValue;

		timeString = timeString.Replace (":", "");
		timeValue = timeValue.Replace (":", "");

		float timePlayer = float.Parse (timeString);
		float timeLevel = float.Parse (timeValue);

		float bonusTime = (timePlayer * 100) / timeLevel;
		bonusTime = 100 - bonusTime;
		bonusTime *= 10;

		int bonus  = (int) bonusTime;
		return bonus;
	}

	public void saveTimeAndPoints(int totalPoints, string timePlayer)
	{
		if (NomeDaFase == "Level 1 Farmacia") 
		{
			if(!PlayerPrefs.HasKey("TimeLevel1") && !PlayerPrefs.HasKey("PointsLevel1"))
			{
				PlayerPrefs.SetString ("TimeLevel1", timePlayer);
				PlayerPrefs.SetInt ("PointsLevel1", totalPoints);

			}else 
			{
				if (PlayerPrefs.GetInt ("PointsLevel1") < totalPoints) 
				{
					PlayerPrefs.SetString ("TimeLevel1", timePlayer);
					PlayerPrefs.SetInt ("PointsLevel1", totalPoints);
				}
			}
		}

		if (NomeDaFase == "Level 2 Supermercado") 
		{
			if(!PlayerPrefs.HasKey("TimeLevel2") && !PlayerPrefs.HasKey("PointsLevel2"))
			{
				PlayerPrefs.SetString ("TimeLevel2", timePlayer);
				PlayerPrefs.SetInt ("PointsLevel2", totalPoints);

			}else 
			{
				if (PlayerPrefs.GetInt ("PointsLevel2") < totalPoints) 
				{
					PlayerPrefs.SetString ("TimeLevel2", timePlayer);
					PlayerPrefs.SetInt ("PointsLevel2", totalPoints);
				}
			}
		}

		if (NomeDaFase == "Level 3 Academia") 
		{
			if(!PlayerPrefs.HasKey("TimeLevel3") && !PlayerPrefs.HasKey("PointsLevel3"))
			{
				PlayerPrefs.SetString ("TimeLevel3", timePlayer);
				PlayerPrefs.SetInt ("PointsLevel3", totalPoints);

			}else 
			{
				if (PlayerPrefs.GetInt ("PointsLevel3") < totalPoints) 
				{
					PlayerPrefs.SetString ("TimeLevel3", timePlayer);
					PlayerPrefs.SetInt ("PointsLevel3", totalPoints);
				}
			}
		}
	}
}