using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance{get;private set;}

    public string Shape;
    public string PlayerName;
    private void Awake(){
        if(Instance!=null){
            Destroy(gameObject);
            return;
        }
        Instance=this;
        DontDestroyOnLoad(gameObject);
        Load();
    }

    [System.Serializable]
    class SaveData
    {
    public string Shape;
    public string Name;
    }
    public void Save()
    {
        SaveData data=new SaveData();
        data.Shape=Shape;
        data.Name=PlayerName;

        string json=JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath+"/savedata.json",json);
    }

    public void Load(){
        string path=Application.persistentDataPath+"/savedata.json";
        if(File.Exists(path)){
            string json=File.ReadAllText(path);
            SaveData data=JsonUtility.FromJson<SaveData>(json);
            Shape=data.Shape;
            PlayerName=data.Name;
        }
    }
}
