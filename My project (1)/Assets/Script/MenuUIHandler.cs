using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    public ShapePicker ShapePicker;
    public InputField NameInput;
    
    public void NewShapeSelected(string shape){
        MainManager.Instance.Shape=shape;
    }
    void Start()
    {
        ShapePicker.Init();
        ShapePicker.onShapeChanged+=NewShapeSelected;
        ShapePicker.SelectShape(MainManager.Instance.Shape);
        NameInput.text=MainManager.Instance.PlayerName;
        NameInput.textComponent.text=MainManager.Instance.PlayerName;
    }

    public void StartNew(){
        SceneManager.LoadScene(1);
    }
    public void Exit() {
        MainManager.Instance.Save();
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit();
        #endif
    }
    public void SaveClicked(){
        MainManager.Instance.Save();
    }
    public void LoadClicked(){
        MainManager.Instance.Load();
    }

    public void setName(){
        MainManager.Instance.PlayerName=NameInput.text;
    }
}
