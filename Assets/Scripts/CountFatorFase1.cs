using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountFatorFase1 : MonoBehaviour {

	public Text AntidepressantTxt;
	int CountAntidepressant = 0;
	public Text VitaminCTxt;
	int CountVitaminC = 0;
	public Text CafeineTxt;
	int CountCafein = 0;
	
	// Update is called once per frame
	void OnCollisionEnter(Collision collision){

		if(collision.gameObject.name == "Antidepressivo(Clone)")
		{
			CountAntidepressant +=1;
			AntidepressantTxt.text = "x" + CountAntidepressant; 

			if( CountAntidepressant == 4)
				AntidepressantTxt.color = Color.blue;
		}

		if(collision.gameObject.name == "Cafeina(Clone)")
		{
			CountCafein +=1;
			CafeineTxt.text = "x" + CountCafein; 

			if( CountCafein == 5)
				CafeineTxt.color = Color.blue;
		}

		if(collision.gameObject.name == "VitaminaC(Clone)")
		{
			CountVitaminC +=1;
			VitaminCTxt.text = "x" + CountVitaminC; 

			if( CountVitaminC == 6)
				VitaminCTxt.color = Color.blue;
		}
	}
}
