using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{

    public static void SaveData (textManager score)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/data.AmazingJere";
        FileStream stream = new FileStream(path, FileMode.Create);

        Data data = new Data(score);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static Data LoadData ()
    {
        string path = Application.persistentDataPath + "/data.AmazingJere";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            Data data = formatter.Deserialize(stream) as Data;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }


}
