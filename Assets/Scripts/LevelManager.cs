using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void LoadMenu(){
		SceneManager.LoadScene("Menu");
	}

	public void LoadLevelOne() {
		SceneManager.LoadScene ("Level 1 Farmacia");
	}

	public void LoadLevelTwo() {
		SceneManager.LoadScene ("Level 2 Supermercado");
	}

	public void LoadLevelThree() {
		SceneManager.LoadScene ("Level 3 Academia");
	}

	public void QuitGame(){
		Debug.Log ("Fechando o jogo...");
	}
		
}
