using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountFatorFase3 : MonoBehaviour {

public Text WaterTxt;
int CountWater = 0;
public Text VitaminCTxt;
int CountVitaminC = 0;
public Text StrawberryTxt;
int CountStrawberry = 0;
public Text DCOTxt;
int CountDCO;
public Text MedicalEvaluationTxt;
int CountMedicalEvaluation;
public Text DumbbellTxt;
int CountDumbbell;
	
	// Update is called once per frame
void OnCollisionEnter(Collision collision){

		if(collision.gameObject.name == "Garrafa água(Clone)")
		{
			CountWater +=1;
			WaterTxt.text = "x" + CountWater; 

			if( CountWater == 6)
				WaterTxt.color = Color.blue;
		}

		if(collision.gameObject.name == "Fruta(Clone)")
		{
			CountStrawberry +=1;
			StrawberryTxt.text = "x" + CountStrawberry; 

			if( CountStrawberry == 6)
				StrawberryTxt.color = Color.blue;
		}

		if(collision.gameObject.name == "VitaminaC(Clone)")
		{
			CountVitaminC +=1;
			VitaminCTxt.text = "x" + CountVitaminC; 

			if( CountVitaminC == 6)
				VitaminCTxt.color = Color.blue;
		}

		if(collision.gameObject.name == "Peso(Clone)")
		{
			CountDumbbell +=1;
			DumbbellTxt.text = "x" + CountDumbbell; 

			if( CountDumbbell == 6)
				DumbbellTxt.color = Color.blue;
		}

		if(collision.gameObject.name == "DCO(Clone)")
		{
			CountDCO +=1;
			DCOTxt.text = "x" + CountDCO; 

			if( CountDCO == 6)
				DCOTxt.color = Color.blue;
		}
		
		if(collision.gameObject.name == "Avaliação Medica(Clone)")
		{
			CountMedicalEvaluation +=1;
			MedicalEvaluationTxt.text = "x" + CountMedicalEvaluation; 

			if( CountMedicalEvaluation == 6)
				MedicalEvaluationTxt.color = Color.blue;
		}
	}
}
