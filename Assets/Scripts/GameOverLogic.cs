using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverLogic : MonoBehaviour {

    public int childCount;
    public void countChildren()
    {
        GameObject buildBoard = GameObject.FindWithTag("Board");

        childCount = buildBoard.transform.childCount;

        Debug.Log(childCount);
    }
}
