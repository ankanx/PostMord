using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class Save : MonoBehaviour {

    public GameObject score;
    public DataCollector scoreList;
    string currentName = "Asd";

    void Start()
    {
        scoreList = new DataCollector();

        LoadFile();
    }

    public void SaveFile(int currentScore)
    {

        // pop out for fetching the name of the player

        string destination = Application.persistentDataPath + "/scoreboard.dat";
        FileStream file;

        if (File.Exists(destination)) file = File.OpenWrite(destination);
        else file = File.Create(destination);

        scoreList.AddScore(currentName,  currentScore.ToString());
        BinaryFormatter bf = new BinaryFormatter();
        bf.Serialize(file, scoreList);
        file.Close();
    }

    public void LoadFile()
    {
        string destination = Application.persistentDataPath + "/scoreboard.dat";
        FileStream file;

        if (File.Exists(destination)) file = File.OpenRead(destination);
        else
        {
            Debug.LogError("File not found");
            return;
        }

        BinaryFormatter bf = new BinaryFormatter();
        DataCollector data = (DataCollector)bf.Deserialize(file);
        file.Close();

        scoreList = data;

        Debug.Log(data.name);
        Debug.Log(data.score);
    }
}
