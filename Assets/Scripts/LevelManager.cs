using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public void LoadLevel() 
    {
        SceneManager.LoadScene("Levels");
    }

    public void LoadDrugStoreLevel()
    {
        SceneManager.LoadScene("Game");
    }

    public void LoadStart()
    {
        SceneManager.LoadScene("Start");
    }
}
