using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PointsManager : MonoBehaviour {

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
	public float curHealth = 0f;
	public int maxHealth = 100;
	int points;
	int controlFunction;
	string NomeDaFase;

	public int qntSpawner;
	public int countSpawner;

	public int qntMedicalEvaluation;
	int countMedicalEvaluation;

	public int qntCafeina;
	int countCafeina;

	public int qntVitaminC;
	int countVitaminC;

	public int qntWater;
	int countWater;

	public int qntAntedrepessant;
	int countAntidepressant;

	public int qntStrawberry;
	int countStrawberry;

	public int qntDumbell;
	int countDumbell;
	public int qntDCO;
	int countDCO;
	bool medical = false;
	bool cafeina;
	bool agua = false;
	bool vitamina = false;
	bool antidepressant = false;
	bool fruta = false;
	bool peso = false;
	bool dco = false;

	void Start () 
	{
		curHealth = maxHealth;
		textPoints.text = "Pontos: ";
		points = 0;
		NomeDaFase = SceneManager.GetActiveScene ().name;
		
		countSpawner = 0;

		countMedicalEvaluation = 1;
		countWater = 1;
		countCafeina = 1;
		countVitaminC = 1;
		countAntidepressant = 1;
		countStrawberry = 1;
		countDumbell = 1;
		countDCO = 1;

		controlFunction = 1;
		
	}

	void Update () 
	{
		
		textPoints.text = "Pontos: " + points;
	}

	void OnCollisionEnter(Collision collision)
	{
		
			if(collision.gameObject.name == "Cafeina(Clone)")
			{
				if(countCafeina < qntCafeina)
				{
					hitGoodThing.Play();
					points += 1;
					countCafeina +=1;
				}
				else if(countCafeina == qntCafeina)
				{
					if(cafeina == false)
					{
						hitGoodThing.Play();
						points += 1;
						cafeina = true;
						countSpawner += 1;
						verificaVitoria(countSpawner);
					}
				}
			}

			if (collision.gameObject.name == "Garrafa água(Clone)") 
			{
				if(countWater < qntWater)
				{
					hitGoodThing.Play ();
					points += 10;
					countWater += 1;
				}
				else if( countWater == qntWater )
				{
					if(agua == false)
					{
						hitGoodThing.Play ();
						points += 10;
						agua = true;
						countSpawner += 1;
						verificaVitoria(countSpawner);
					}
				}
			}	
			
			if(collision.gameObject.name == "Antidepressivo(Clone)")
			{
				if(countAntidepressant < qntAntedrepessant)
				{
					hitGoodThing.Play();
					points += 5;
					countAntidepressant +=1;
				}
				else if(countAntidepressant == qntAntedrepessant)
				{
					if(antidepressant == false)
					{
						hitGoodThing.Play();
						points += 5;
						antidepressant = true;
						countSpawner += 1;
						verificaVitoria(countSpawner);
					}
				}
			}
			if (collision.gameObject.name == "Avaliação Medica(Clone)") 
			{
				if( countMedicalEvaluation < qntMedicalEvaluation)
				{
					hitGoodThing.Play ();
					points += 15;
					countMedicalEvaluation += 1;
				} 
				else if(countMedicalEvaluation == qntMedicalEvaluation)
				{ 
					if(medical == false)
					{ 
						hitGoodThing.Play ();
						points += 15;
						medical = true;
						countSpawner += 1;
						verificaVitoria(countSpawner);
					}
					
				}
				
			}
			
			if (collision.gameObject.name == "VitaminaC(Clone)") 
			{
				if(countVitaminC < qntVitaminC)
				{
					hitGoodThing.Play ();
					points += 10;
					countVitaminC += 1;
					controlHeartBeat (countVitaminC);
				} 
				else if( countVitaminC == qntVitaminC )
				{
					if(vitamina == false)
					{
						hitGoodThing.Play ();
						points += 10;
						controlHeartBeat (countVitaminC);
						vitamina = true;
						countSpawner += 1;
						verificaVitoria(countSpawner);
					}
				}
			}

			if (collision.gameObject.name == "Fruta(Clone)") 
			{
				if(countStrawberry < qntStrawberry)
				{
					hitGoodThing.Play ();
					points += 15;
					countStrawberry += 1;
				}
				else if(countStrawberry == qntStrawberry)
				{
					if(fruta == false)
					{
						hitGoodThing.Play ();
						points += 15;
						fruta = true;
						countSpawner += 1;
						verificaVitoria(countSpawner);
					}
				}
			}

			if (collision.gameObject.name == "Peso(Clone)") 
			{
				if(countDumbell < qntDumbell)
				{
					hitGoodThing.Play ();
					points += 25;
					countDumbell += 1;
				}
				else if(countDumbell == qntDumbell)
				{ 
					if(peso == false)
					{
						hitGoodThing.Play ();
						points += 25;
						peso = true;
						countSpawner += 1;
						verificaVitoria(countSpawner);
					}
				}
			}

			if (collision.gameObject.name == "DCO(Clone)") 
			{
				if(countDCO < qntDCO)
				{
					hitGoodThing.Play ();
					points += 1;
					countDCO += 1;
				}
				else if(countDCO == qntDCO)
				{ 
					if(dco == false)
					{
						hitGoodThing.Play ();
						points += 5;
						dco = true;
						countSpawner += 1;
						verificaVitoria(countSpawner);
					}
				}
			}

			if ( collision.gameObject.name == "Termogenico(Clone)") 
			{
				hitBadThing.Play ();
				curHealth -= 20;
				float calcHealth = curHealth / maxHealth;
				setHealthBar (calcHealth);

				verificaHealth(calcHealth);
			}

			if(collision.gameObject.name == "Suplemento(Clone)")
			{
				hitBadThing.Play();
				curHealth -= 20;
				float calcHealth = curHealth / maxHealth;
				setHealthBar(calcHealth);

				verificaHealth(calcHealth);
			}

			if(collision.gameObject.name == "EPO(Clone)")
			{
				hitBadThing.Play();
				curHealth -= 20;
				float calcHealth = curHealth / maxHealth;
				setHealthBar(calcHealth);

				verificaHealth(calcHealth);
			}

			if(collision.gameObject.name == "GH(Clone)")
			{
				hitBadThing.Play();
				curHealth -= 20;
				float calcHealth = curHealth / maxHealth;
				setHealthBar(calcHealth);

				verificaHealth(calcHealth);
			}

			if(collision.gameObject.name == "Efedrina(Clone)")
			{
				hitBadThing.Play();
				curHealth -= 20;
				float calcHealth = curHealth / maxHealth;
				setHealthBar(calcHealth);

				verificaHealth(calcHealth);
			}
			
			if(collision.gameObject.name == "Diuretico(Clone)")
			{
				hitBadThing.Play();
				curHealth -= 20;
				float calcHealth = curHealth / maxHealth;
				setHealthBar(calcHealth);

				verificaHealth(calcHealth);
			}

			if (collision.gameObject.name == "Testosterona(Clone)") 
			{
				hitBadThing.Play ();
				curHealth -= 20;
			    float calcHealth = curHealth / maxHealth;
				setHealthBar (calcHealth);

				verificaHealth(calcHealth);
			}
			
			if (collision.gameObject.name == "Cigarro(Clone)") 
			{
				hitBadThing.Play ();
				curHealth -= 20;
				float calcHealth = curHealth / maxHealth;
				setHealthBar (calcHealth);

				verificaHealth(calcHealth);
			}

			if (collision.gameObject.name == "Suplemento(Clone)") 
			{
				hitBadThing.Play ();
				curHealth -= 20;
				float calcHealth = curHealth / maxHealth;
				setHealthBar (calcHealth);

				verificaHealth(calcHealth);
				
			}

			if (collision.gameObject.name == "Energetico(Clone)") 
			{
				hitBadThing.Play ();
				curHealth -= 20;
				float calcHealth = curHealth / maxHealth;
				setHealthBar (calcHealth);

				verificaHealth(calcHealth);
			}

			if ( collision.gameObject.name == "Anabolizante(Clone)") 
			{
				hitBadThing.Play ();
				curHealth -= 20;
				float calcHealth = curHealth / maxHealth;
				setHealthBar (calcHealth);

				verificaHealth(calcHealth);
			}

			if ( collision.gameObject.name == "Canabis(Clone)") 
			{
				hitBadThing.Play ();
				curHealth -= 20;
				float calcHealth = curHealth / maxHealth;
				setHealthBar (calcHealth);

				verificaHealth(calcHealth);
			}
				
	}

    public void setHealthBar(float myHealth)
    {
        HealthBar.transform.localScale = new Vector3(myHealth, HealthBar.transform.localScale.y, HealthBar.transform.localScale.z);
    }

	public void verificaHealth(float calcHealth)
	{
		if (calcHealth == 0) 
		{ 
			run.Stop ();
			Time.timeScale = 0;
			HeartControl heartControl = Heart.GetComponent<HeartControl> ();
			heartControl.velocityBeat = 0;
			timeUI.gameObject.SetActive (false);
			textPoints.gameObject.SetActive (false);
			UILevelsManager uiManager = UIManager.GetComponent<UILevelsManager> ();
			uiManager.OpenGameOverUI ();
			totalPointsUIGOver.text = "Pontos: " + points;
			TimerManager timeManager = UIManager.GetComponent<TimerManager> ();
			totalTimeUIGOver.text = "Tempo: " + timeManager.timeString;
		}	
	}

	public void verificaVitoria(int countSpawner)
	{
		if(countSpawner == qntSpawner)
		{
			run.Stop ();
			Time.timeScale = 0;
			PlayerPrefs.SetInt ("" + NomeDaFase, 1);
			HeartControl heartControl = Heart.GetComponent<HeartControl> ();
			heartControl.velocityBeat = 0;

			timeUI.gameObject.SetActive (false);
			textPoints.gameObject.SetActive (false);

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
	}
	public void controlHeartBeat(int countVitaminC)
	{
		
		float percentVitaminC = (countVitaminC * 100) / qntVitaminC; 
		
		if ((percentVitaminC >= 0 && percentVitaminC <= 25) && controlFunction == 1) {
			HeartControl heartControl = Heart.GetComponent<HeartControl> ();
			heartControl.velocityBeat = 0.6f;
			controlFunction += 1;
		} else if (( percentVitaminC >= 26 && percentVitaminC <= 50) && controlFunction == 2) 
		{
			HeartControl heartControl = Heart.GetComponent<HeartControl> ();
			heartControl.velocityBeat = 0.9f;
			controlFunction += 1;
		}else if ((percentVitaminC >= 51 && percentVitaminC <= 75) && controlFunction == 3)
		{
			HeartControl heartControl = Heart.GetComponent<HeartControl> ();
			heartControl.velocityBeat = 1.2f;
			controlFunction += 1;
		}else if (percentVitaminC >= 76 && controlFunction == 4)
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