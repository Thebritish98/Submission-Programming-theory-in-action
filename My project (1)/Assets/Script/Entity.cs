using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    //POLYMORPHISM
    public Shape shape;
    
    public void Start(){
        switch (MainManager.Instance.Shape)
        {
            case "CUBE":
                shape=new Cube();
                break;
            case "SPHERE":
                shape=new Sphere();
                break;
        }
    }
}
