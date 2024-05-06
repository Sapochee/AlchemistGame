using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public static int orderValue=121;
public static int bottleValue=000;

public class clickplace : MonoBehavior
{
    public Transform cloneObj;
    public int liquidValue;

    void Start()

    {

    }

    void Update()
    {

    }
    private void OnMouseDown()
    {
        if (gameObject.name=="bottomLayer")
        Instantiate(cloneObj,new Vector3(0, .10f, 0), cloneObj.rotation);

        if (gameObject.name=="middleLayer")
        Instantiate(cloneObj,new Vector3(0, .60f, 0), cloneObj.rotation);

        if (gameObject.name=="topLayer")
        Instantiate(cloneObj,new Vector3(0, .62f, 0), cloneObj.rotation);

        gameflow.bottleValue += liquidValue;
        Debug.Log(gameflow.plateValue+" "+gameflow.orderValue);
    }
}