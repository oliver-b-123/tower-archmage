using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonLoop : MonoBehaviour
{
    public GameObject circle;

    //Initialization
    void Start()
    {
        //circle = GameObject.Find("Circle");
        Instantiate(circle, new Vector3(0,0,0f));
    }

    //Loop
    void Update()
    {
        //circle.transform.translate(0,1,0);
    }
}
