using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PointsManager : MonoBehaviour {

    bool gameIsPaused = false;
    public Text textPoints;
    public Text totalPoints;
	public Text totalTimeUI;
	public Text timeUI;
    public int maxHealth = 100;
    public float curHealth = 0f;
    public GameObject HealthBar;
	public GameObject Heart;
	public GameObject UIManager;
    public Canvas GameOverUI;
	public Canvas LevelCompleteUI;
    public AudioSource hitSphere;
    public AudioSource hitCube;
	public int qntWaterbottle; 
	string NomeDaFase;
	int countWaterbottle;
	int points;

	void Start () 
	{
        curHealth = maxHealth;
		textPoints.text = "POINTS: ";
		points = 0;
		NomeDaFase = SceneManager.GetActiveScene ().name;
		//PlayerPrefs.DeleteAll ();
	}

	void Update () 
	{
		textPoints.text = "POINTS: " + points;
	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.name == "Water(Clone)") {
            points += 10;
			countWaterbottle += 1;
			//HeartControl heartControl = Heart.GetComponent<HeartControl> ();
			//heartControl.velocityBeat /= 0.75f;
           // hitSphere.Play();
        }

		if ( qntWaterbottle == countWaterbottle ) {
			Time.timeScale = 0;
			PlayerPrefs.SetInt(""+NomeDaFase, 1  );
			HeartControl heartControl = Heart.GetComponent<HeartControl> ();
			heartControl.velocityBeat = 0;
			LevelCompleteUI.gameObject.SetActive (true);
		}

		if (collision.gameObject.name == "Testosterone(Clone)") {
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
                totalPoints.text = "TOTAL POINTS: " + points;
				TimerManager timeManager = UIManager.GetComponent<TimerManager> ();
				totalTimeUI.text = "TEMPO: " + timeManager.timeString;
            }
        }        
     }

    public void setHealthBar(float myHealth)
    {
        HealthBar.transform.localScale = new Vector3(myHealth, HealthBar.transform.localScale.y, HealthBar.transform.localScale.z);
    }

}
