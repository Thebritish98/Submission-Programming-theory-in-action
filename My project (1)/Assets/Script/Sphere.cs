using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class Sphere : Shape
{
    public Sphere(){
        gameObject=GameObject.CreatePrimitive(PrimitiveType.Sphere);
        //InitCollider("SPHERE");
        action=Act;
    }
    public override void Act()
    {
        Debug.Log(MainManager.Instance.PlayerName+"'s Sphere is touched!");
    }
}
