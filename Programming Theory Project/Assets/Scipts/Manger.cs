using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Manger : MonoBehaviour
{
    Tiger x;
    Snake y;

    
    // Start is called before the first frame update
    void Start()
    {
        x = GameObject.Find("tiger").GetComponent<Tiger>();
        y = GameObject.Find("Snake").GetComponent<Snake>();

        x.animalName = "tiger";
        x._animalSpeed = -1;

        x.animalName = "snake";
        x._animalSpeed = 2;
    }

    // Update is called once per frame
    private void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            x.Speak();
            y.Speak();
            x.Moving();
            y.Moving();
        }
        if (Input.GetMouseButtonDown(1))
        {
            x.Moving(Camera.main.ScreenToWorldPoint(Input.mousePosition));
            y.Moving(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        }
    }
}
