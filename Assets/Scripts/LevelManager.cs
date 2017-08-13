using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void LoadMenu(){
		SceneManager.LoadScene("Menu");
	}

	public void LoadSelecionarFase(){
		SceneManager.LoadScene("Selecao de Fases");
	}

	public void LoadLevelOne() {
		SceneManager.LoadScene ("Level 1 Farmacia");
	}

	public void LoadLevelTwo() {
		if (PlayerPrefs.HasKey("Level 1 Farmacia")) {
			SceneManager.LoadScene ("Level 2 Supermercado");
		}
	}

	public void LoadLevelThree() {
		if (PlayerPrefs.HasKey ("Level 2 Supermercado")) {
			SceneManager.LoadScene ("Level 3 Academia");
		}	
	}

	public void QuitGame(){
		Debug.Log ("Fechando o jogo...");
	}
		
}
