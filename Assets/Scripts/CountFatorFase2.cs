using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountFatorFase2 : MonoBehaviour {
public Text WaterTxt;
int CountWater = 0;
public Text VitaminCTxt;
int CountVitaminC = 0;
public Text StrawberryTxt;
int CountStrawberry = 0;
	
	// Update is called once per frame
void OnCollisionEnter(Collision collision){

		if(collision.gameObject.name == "Garrafa água(Clone)")
		{
			CountWater +=1;
			WaterTxt.text = "x" + CountWater; 

			if( CountWater == 6)
				WaterTxt.color = Color.red;
		}

		if(collision.gameObject.name == "Fruta(Clone)")
		{
			CountStrawberry +=1;
			StrawberryTxt.text = "x" + CountStrawberry; 

			if( CountStrawberry == 6)
				StrawberryTxt.color = Color.red;
		}

		if(collision.gameObject.name == "VitaminaC(Clone)")
		{
			CountVitaminC +=1;
			VitaminCTxt.text = "x" + CountVitaminC; 

			if( CountVitaminC == 6)
				VitaminCTxt.color = Color.red;
		}
	}
}
