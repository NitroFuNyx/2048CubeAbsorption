using System;
using UnityEngine;

public class JsonFileWriter : MonoBehaviour
{
    public JsonData data;

    public string path;

    public void Start()
    {
        LoadResourceTextFile();
    }

    public void LoadResourceTextFile()
    {
        string filePath = "Localization/Languages";
        TextAsset targetFile = Resources.Load<TextAsset>(filePath);
        data = JsonUtility.FromJson<JsonData>(targetFile.text);
    }
}

[Serializable]
public class LocalizedData
{
    public string ru;
    public string eng;
}

[Serializable]
public class JsonData
{
    public LocalizedData playBtn;

    public JsonData()
    {
    }
}