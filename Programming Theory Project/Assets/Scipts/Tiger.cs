using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiger : Animal
{

    private void Start()
    {
      
        moveType = MoveType.Walk;
        size = Size.Medium;
        speed = Speed.Fast;
    }

    public override void Moving()
    {
        base.Moving();
    }
    public override void Speak()
    {
        base.Speak();
        Debug.Log("Tigo bye");
    }

    

}
