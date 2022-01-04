using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShapeButton : Button
{
    public string shapename=null;
    public void set(string _shapesType){
        shapename=_shapesType;
        this.GetComponentInChildren<TMP_Text>().text=shapename;
    }
}
