using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ABSTRACTION
public abstract class Shape
{
    //protected Collider m_Collider;
    protected GameObject Entity;
    protected GameObject gameObject;
    protected System.Action action;
    //ENCAPSULATION
    public string Name{get; protected set;}
    protected float m_size;
    public float Size{
        get{
            return m_size;
        }
        set{
            if(value<0.0f)
                Debug.Log("Not negative Size possible!");
            else
                m_size=value;
        }
    }
    public abstract void Act();
    private void OnMouseDown() {
        action.Invoke();
    }
}
