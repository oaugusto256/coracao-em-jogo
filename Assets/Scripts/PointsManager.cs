﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsManager : MonoBehaviour {

    bool gameIsPaused = false;
    public Text textPoints;
    public Text totalPoints;
    public int maxHealth = 100;
    public float curHealth = 0f;
    public GameObject HealthBar;
    public Canvas GameOverUI;
    public AudioSource hitSphere;
    public AudioSource hitCube;
    int points;

	void Start () {
        curHealth = maxHealth;
		textPoints.text = "POINTS: ";
		points = 0;
	}

	void Update () {
		textPoints.text = "POINTS: " + points;
	}

	void OnCollisionEnter(Collision collision)
	{
        if (collision.gameObject.name == "Cube(Clone)") {
            points += 10;
            /// hitSphere.Play();
        }
		

        if (collision.gameObject.name == "Sphere(Clone)") {
            curHealth -= 20;
            // hitCube.Play();
            float calcHealth = curHealth / maxHealth;
            setHealthBar(calcHealth);

            if (calcHealth == 0)
            {
                Time.timeScale = 0;
                textPoints.gameObject.SetActive(false);
                GameOverUI.gameObject.SetActive(true);
                totalPoints.text = "TOTAL POINTS: " + points;
            }
        }        
     }

    public void setHealthBar(float myHealth)
    {
        HealthBar.transform.localScale = new Vector3(myHealth, HealthBar.transform.localScale.y, HealthBar.transform.localScale.z);
    }
}
