using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public static int orderValue=121;
public static int bottleValue=000;

public class serverbottle : MonoBehavior
{

    void Start()
    {

    }

    void Update()
    {

    }
    private void OnMouseDown()
    {
        if (gameflow.orderValue==gameflow.bottleValue)
        {
            Debug.Log("correct");
        }
    }
}