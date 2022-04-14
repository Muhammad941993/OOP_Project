using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : Animal
{

    private void Start()
    {
        moveType = MoveType.creep;
        size = Size.Small;
        speed = Speed.Slow;
    }

    // Update is called once per frame
   

    public override void Speak()
    {
        base.Speak();
        Debug.Log("Snake bye");
    }

    public override void Moving()
    {
        base.Moving();
    }
    public override void Moving(Vector3 pos)
    {
        base.Moving(-pos);
    }

  
}
