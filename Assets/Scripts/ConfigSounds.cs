using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfigSounds : MonoBehaviour {

	GameObject findObj;
	AudioSource music;
	public Slider mscSounds;
	public Slider btnSound;
	public Slider sndEfects;
	float atualMscSnds;
	float antMscSnds;
	float atualBtnValue;
	float antBtnValue;
	float atualSndEfct;
	float antSndEfct;

	void Start()
	{
		findObj = GameObject.Find ("AudioManager");
		music = findObj.GetComponent<AudioSource> ();

		if( PlayerPrefs.HasKey ("mscValue") )
		{
			mscSounds.value = PlayerPrefs.GetFloat("mscValue");
			music.volume = PlayerPrefs.GetFloat("mscValue");
			antMscSnds = PlayerPrefs.GetFloat("mscValue");	
		} else 
		{
			antMscSnds = 1;	
		}

		if( PlayerPrefs.HasKey ("btnValue") )
		{
			btnSound.value = PlayerPrefs.GetFloat("btnValue");
			antBtnValue = PlayerPrefs.GetFloat("btnValue");	
		} else 
		{
			antBtnValue = 1;	
		}

		if( PlayerPrefs.HasKey ("efcValue") )
		{
			sndEfects.value = PlayerPrefs.GetFloat("efcValue");
			antSndEfct = PlayerPrefs.GetFloat("efcValue");	
		} else 
		{
			antSndEfct = 1;	
		}
	}

	void Update()
	{

		atualMscSnds = mscSounds.value;

		atualBtnValue = btnSound.value;

		atualSndEfct = sndEfects.value;

		if( antMscSnds != atualMscSnds )
		{
			saveNewMscValue ( atualMscSnds );
			music.volume = atualMscSnds;
			antMscSnds = atualMscSnds;
		}

		if( antBtnValue != atualBtnValue)
		{
			saveNewBtnValue( atualBtnValue);
			antBtnValue = atualBtnValue;
		}

		if( antSndEfct != atualSndEfct )
		{
			saveNewEfcValue ( atualSndEfct );
			antSndEfct = atualSndEfct;
		}
	}

	void saveNewMscValue( float mscValue )
	{
		PlayerPrefs.SetFloat ("mscValue", mscValue);
	}

	void saveNewBtnValue( float btnValue)
	{
		PlayerPrefs.SetFloat ("btnValue", btnValue);
	}

	void saveNewEfcValue (float efcValue)
	{
		PlayerPrefs.SetFloat ("efcValue", efcValue);
	}
}
