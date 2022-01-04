using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapePicker : MonoBehaviour
{
    public enum Shapes{
        SPHERE,CUBE
    }
    public string[] AvailableShapes;
    public string SelectedShape{get;private set;}
    public ShapeButton ShapeButtonPrefab;

    public System.Action<string> onShapeChanged;

    List<ShapeButton> m_ShapeButtons = new List<ShapeButton>();
    // Start is called before the first frame update
    public void Init()
    {
        foreach (var shape in AvailableShapes)
        {
           var newButton = Instantiate(ShapeButtonPrefab, transform);
           newButton.set(shape);

           newButton.onClick.AddListener(()=>
           {
               SelectedShape=shape;
               foreach (var button in m_ShapeButtons)
               {
                   button.interactable=true;
               }
               newButton.interactable=false;
               onShapeChanged.Invoke(SelectedShape);
           });
           m_ShapeButtons.Add(newButton);
        }
    }

    public void SelectShape(string _shapename)
    {
        for (int i = 0; i < AvailableShapes.Length; i++)
        {
            if(AvailableShapes[i]==_shapename){
                m_ShapeButtons[i].onClick.Invoke();
            }
        }
    }
}
