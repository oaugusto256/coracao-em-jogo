using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VerifyCollisionGoodThing : MonoBehaviour
{

    bool gameIsPaused = false;
    public Canvas OptionScreen;
    public RawImage PositiveGreenLightBulb;
    public Button YesButton;

    // Use this for initialization
    void Start()
    {
        Button btn = YesButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        if( PositiveGreenLightBulb.gameObject.activeSelf == true)
        {
            print("teste");
        }
    }

    void TaskOnClick()
    {
        Time.timeScale = 1;

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "GoodThing")
        {
            OptionScreen.gameObject.SetActive(true);
            gameIsPaused = true;
            Time.timeScale = 0;
         }

        
    }
    
}
