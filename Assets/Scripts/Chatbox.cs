using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Chatbox : MonoBehaviour
{

    [SerializeField] PlayerController player;

    public bool isActive;
    public GameObject[] ChatElements;
    public Camera playerCam;
    public bool isFightBox = false;
    public bool isFightClicked = false;
    public float countdown = 1.0f;

    // Start is called before the first frame update
    void Start()
    {

        playerCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        ChatElements = GameObject.FindGameObjectsWithTag("Chatbox");
        hideChat();
        isActive = false;

    }

    // Update is called once per frame
    void Update()
    {

        if (isActive)
        {

            if (Input.GetMouseButtonDown(0))
            {

                if (isFightBox)
                {

                    isFightClicked = true;

                }
                else if (isFightBox == false)
                {

                    player.isMoveEnabled = true;                      
                    hideChat();
                    isActive = false;
                    Cursor.visible = false;
                    Cursor.lockState = CursorLockMode.Locked;

                }

            }

        }

        if (isFightClicked)
        {

            Debug.Log(playerCam.orthographicSize);

            countdown -= 1f * Time.deltaTime * 4;
            playerCam.orthographicSize -= 0.0625f;
            player.GetComponent<PauseScript>().blackBox.color = new Color(0, 0, 0, player.GetComponent<PauseScript>().blackBox.color.a + 0.1f);

            if (countdown < 0.0f)
            {

                isFightBox = false;
                isFightClicked = false;
                countdown = 1.0f;
                hideChat();
                SceneManager.LoadScene("FightScene");

            }

        }

    }

    public void openChatbox()
    {

        isActive = true;

        if (isActive)
        {

            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            player.isMoveEnabled = false;
            showChat();

        }

    }

    void hideChat()
    {

        foreach (GameObject u in ChatElements)
        {
            
            u.SetActive(false);

        }

    }

    void showChat()
    {

        foreach (GameObject u in ChatElements)
        {

            u.SetActive(true);

        }

    }

}
