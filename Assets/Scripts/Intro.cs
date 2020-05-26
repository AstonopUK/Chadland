using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class Intro : MonoBehaviour
{

    [SerializeField] Chatbox chat;
    [SerializeField] Text textField;

    int boxesUntilWarp;
    string readString;

    // Start is called before the first frame update
    void Start()
    {

        chat.openChatbox();

    }

    // Update is called once per frame
    void Update()
    {

        if (boxesUntilWarp == 7)
        {

            GameObject Player = GameObject.FindGameObjectWithTag("Player");
            Player.transform.position = new Vector3(4, 16.5f, 0);
            SceneManager.LoadScene("ChadHouse");

        }

        switch (boxesUntilWarp)
        {

            case 0:
                ReadString(("God" + (boxesUntilWarp + 1)));
                chat.openChatbox();
                textField.text = readString;
                break;

            case 1:
                ReadString(("God" + (boxesUntilWarp + 1)));
                chat.openChatbox();
                textField.text = readString;
                break;

            case 2:
                ReadString(("God" + (boxesUntilWarp + 1)));
                chat.openChatbox();
                textField.text = readString;
                break;

            case 3:
                ReadString(("God" + (boxesUntilWarp + 1)));
                chat.openChatbox();
                textField.text = readString;
                break;

            case 4:
                ReadString(("God" + (boxesUntilWarp + 1)));
                chat.openChatbox();
                textField.text = readString;
                break;

            case 5:
                ReadString(("God" + (boxesUntilWarp + 1)));
                chat.openChatbox();
                textField.text = readString;                
                break;

            case 6:
                ReadString(("God" + (boxesUntilWarp + 1)));
                chat.openChatbox();
                textField.text = readString;
                break;

        }

        if (Input.GetMouseButtonDown(0))
        {

            boxesUntilWarp++;

        }

    }

    public void ReadString(string iName)
    {

        string path = (Application.dataPath + "/GameText/" + iName + ".txt");

        //Read the text from directly from the test.txt file
        StreamReader reader = new StreamReader(path);
        readString = reader.ReadToEnd();
        reader.Close();

    }

}
