using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class MenuScript : MonoBehaviour
{

    string readString;
    int stringConvert;

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log(Application.persistentDataPath);

    }

    // Update is called once per frame
    void Update()
    {
        


    }

    public void StartGame()
    {

        ReadString();
        stringConvert = int.Parse(readString);

        if (stringConvert == 0)
        {

            SceneManager.LoadScene("Intro");

        }
        else
        {

            SceneManager.LoadScene("ChadRealm");

        }

    }

    public void ExitGame()
    {

        Application.Quit();

    }

    public void ReadString()
    {

        string path = (Application.dataPath + "/GameText/Save.txt");

        //Read the text from directly from the test.txt file
        StreamReader reader = new StreamReader(path);
        readString = reader.ReadToEnd();
        reader.Close();

    }

}
