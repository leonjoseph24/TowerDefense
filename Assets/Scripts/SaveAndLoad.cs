using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


public class SaveAndLoad : MonoBehaviour {
    public Text playerInputName;  
    public Text playerLoadedName;

    string filepath;
	// Use this for initialization
	void Start () {
        filepath = Application.persistentDataPath + Path.DirectorySeparatorChar;   // to show the location and directory of the file that this is going to be loaded and saved from.

        if (File.Exists(filepath + "savefile.name")) // to load any existing files from its location in directory.
        {
            using (System.IO.FileStream Fs = File.Open(filepath + "savefile.name", FileMode.Open))  // loads the file by converting it into binary then formatting it into a string.
            {
                BinaryFormatter Bf = new BinaryFormatter();
                playerLoadedName.text = (string)Bf.Deserialize(Fs);
            }

        }
        else
        {
            playerLoadedName.text = "No saved names";
        }
	}

    public void SaveNameToFile()
    {
       

        using (System.IO.FileStream Fs = File.Open(filepath + "savefile.name", FileMode.Create)) // creates a new file to be saved by converting the string into binary.
        {
            BinaryFormatter Bf = new BinaryFormatter();   
            Bf.Serialize(Fs, playerInputName.text);
        }
    }

    public void LoadNameFromFile()
    {
        playerLoadedName.color = Color.yellow;

        using (System.IO.FileStream Fs = File.Open(filepath + "savefile.name", FileMode.Open)) // loads the file by converting it into binary then formatting it into a string.
        {
            BinaryFormatter Bf = new BinaryFormatter();
            playerLoadedName.text = (string)Bf.Deserialize(Fs);
        }
    }

    public void OnSaveClick()   // to enable the button to save and load the game at the same time.
    {
        if(playerInputName.text != "")
        {
            SaveNameToFile();
            LoadNameFromFile();

        }
        else
        {
            playerLoadedName.color = Color.red;
            playerLoadedName.text = "Name must be entered !";
        }
             
    }
		
}
