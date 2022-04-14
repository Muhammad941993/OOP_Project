using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{

    public string animalName;

    private int animalSpeed;
    public int _animalSpeed
    {
        get { return animalSpeed; }
        set
        {
            if(_animalSpeed < 0)
            {
                Debug.Log("Cant be negative");
                animalSpeed = 0;
            }
            else
            {
                animalSpeed = value;
            }
        }
    }
   

    protected MoveType moveType;
    protected Size size;
    protected Speed speed;


    
    public virtual void Moving() { transform.position += Vector3.right; }
    public virtual void Moving(Vector3 pos) { transform.position = pos; }
    public virtual void Speak()
    {
        
        Debug.Log("Hello "+" my name is :" + animalName
           + " my speed :" + animalSpeed
           + " I can " + moveType.ToString()
           + speed.ToString() + " Im a " + size.ToString() + " Size");
    }


}


public enum MoveType { Fly , Walk , creep}
public enum Size { Small , Medium , Large}

public enum Speed { Slow , Moderate , Fast}
