using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class Cube : Shape
{
    public Cube(){
        gameObject=GameObject.CreatePrimitive(PrimitiveType.Cube);
        //InitCollider("CUBE");
        action=Act;
    }
    public override void Act()
    {
        Debug.Log(MainManager.Instance.PlayerName+"'s Cube is touched!");
    }
}
