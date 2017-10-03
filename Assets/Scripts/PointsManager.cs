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
    public Canvas GameOverUI;
	public Canvas LevelCompleteUI;
    public AudioSource hitSphere;
    public AudioSource hitCube;
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
		textPoints.text = "POINTS: ";
		points = 0;
		NomeDaFase = SceneManager.GetActiveScene ().name;
		countWaterbottle = 0;
		controlFunction = 1;
	}

	void Update () 
	{
		textPoints.text = "POINTS: " + points;
	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.name == "Water(Clone)")
		{
            points += 10;
			countWaterbottle += 1;
			controlHeartBeat (countWaterbottle);
	    }

		if ( qntWaterbottle == countWaterbottle ) 
		{
			Time.timeScale = 0;
			PlayerPrefs.SetInt(""+NomeDaFase, 1  );
			HeartControl heartControl = Heart.GetComponent<HeartControl> ();
			heartControl.velocityBeat = 0;

			timeUI.gameObject.SetActive (false);
			textPoints.gameObject.SetActive(false);

			LevelCompleteUI.gameObject.SetActive (true);

			TimerManager timeManager = UIManager.GetComponent<TimerManager> ();
			totalTimeUILComplete.text = "TEMPO: " + timeManager.timeString;

			pointsUILComplete.text = "PONTOS: " + points;

			int bonus = calculateBonusTime ();
			bonusTimeUILComplete.text = "BÔNUS POR TEMPO: x" + bonus;

			int totalPoints = points * bonus;
			totalPointsUILComplete.text = "TOTAL: " + totalPoints;

		}

		if (collision.gameObject.name == "Testosterone(Clone)") 
		{
            curHealth -= 20;
            // hitCube.Play();
            float calcHealth = curHealth / maxHealth;
            setHealthBar(calcHealth);

            if (calcHealth == 0)
            {
                Time.timeScale = 0;
				HeartControl heartControl = Heart.GetComponent<HeartControl> ();
				heartControl.velocityBeat = 0;
				timeUI.gameObject.SetActive (false);
                textPoints.gameObject.SetActive(false);
                GameOverUI.gameObject.SetActive(true);
                totalPointsUIGOver.text = "PONTOS: " + points;
				TimerManager timeManager = UIManager.GetComponent<TimerManager> ();
				totalTimeUIGOver.text = "TEMPO: " + timeManager.timeString;
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

}
