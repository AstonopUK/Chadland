using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class InteractionObjective : MonoBehaviour
{

    string readString;

    Chatbox playerChat;
    [SerializeField] Text uiText;

    // Start is called before the first frame update
    void Start()
    {
        
        playerChat = GameObject.FindGameObjectWithTag("Player").GetComponent<Chatbox>();

    }

    // Update is called once per frame
    void Update()
    {
       
        

    }

    public void interactCircumstance(string name)
    {

        switch (name)
        {

            case "BigCounter":
                ReadString(name);
                playerChat.openChatbox();
                uiText.text = readString;
                break;

            case "Bike":
                ReadString(name);
                playerChat.openChatbox();
                uiText.text = readString;
                break;

            case "Bed":
                ReadString(name);
                playerChat.openChatbox();
                uiText.text = readString;
                break;

            case "Drawers":
                ReadString(name);
                playerChat.openChatbox();
                uiText.text = readString;
                break;

            case "Stairs":
                ReadString(name);
                playerChat.openChatbox();
                uiText.text = readString;
                break;

            case "Radio":
                ReadString(name);
                playerChat.openChatbox();
                uiText.text = readString;
                break;

            case "HomeTV":
                ReadString(name);
                playerChat.openChatbox();
                uiText.text = readString;
                break;

            case "Water":
                ReadString(name);
                playerChat.openChatbox();
                uiText.text = readString;
                break;

            case "Enemy":
                ReadString(name);
                playerChat.isFightBox = true;
                playerChat.openChatbox();
                uiText.text = readString;
                break;

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
