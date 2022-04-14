using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Manger : MonoBehaviour
{
    Tiger x;
    Snake y;
    public GameObject marker;
    
    // Start is called before the first frame update
    void Start()
    {
        x = GameObject.Find("tiger").GetComponent<Tiger>();
        y = GameObject.Find("Snake").GetComponent<Snake>();

        x.animalName = "tiger";
        x._animalSpeed = 10;

        x.animalName = "snake";
        x._animalSpeed = 2;
    }

    // Update is called once per frame
    private void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
          
            RaycastHit hitInfo = new RaycastHit();
            bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
            if (hit)
            {
                var l = hitInfo.transform.gameObject;
               
               if( l.GetComponent<ISelected>() != null)
                {
                    SetMarker(l.transform.position);
                    l.GetComponent<ISelected>().Select();
                }

            }
            else
            {
                Debug.Log("No hit");
            }
           
        }
    }

    void SetMarker(Vector3 pos)
    {
        marker.SetActive(true);
        marker.transform.position = pos + new Vector3(0, 1, 0);
    }
}
