using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour
{

    public bool isPaused = false;
    public Image blackBox;

    public GameObject[] SettingsUIElements;
    public GameObject[] PauseUIElements;

    [SerializeField] AudioSource OpenUI;
    [SerializeField] AudioSource CloseUI;
    [SerializeField] PlayerController player;

    // Start is called before the first frame update
    void Start()
    {

        blackBox.color = new Color(blackBox.color.r, blackBox.color.g, blackBox.color.b, 0);

        SettingsUIElements = GameObject.FindGameObjectsWithTag("SettingsMenu");
        hideSettingsUI();

        PauseUIElements = GameObject.FindGameObjectsWithTag("PauseMenu");
        hidePauseUI();

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
        isPaused = false;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("escape"))
        {

            if (isPaused == false)
            {

                OpenUI.Play();

                Time.timeScale = 0;

                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;

                showPauseUI();
                player.isMoveEnabled = false;
                isPaused = true;

            }

        }

    }

    void hideSettingsUI()
    {

        foreach (GameObject u in SettingsUIElements)
        {

            u.SetActive(false);

        }

    }

    void showSettingsUI()
    {

        foreach (GameObject u in SettingsUIElements)
        {

            u.SetActive(true);

        }

    }

    void hidePauseUI()
    {

        foreach (GameObject u in PauseUIElements)
        {

            u.SetActive(false);

        }

    }

    void showPauseUI()
    {

        foreach (GameObject u in PauseUIElements)
        {

            u.SetActive(true);

        }

    }

    public void Resume() { player.isMoveEnabled = true; CloseUI.Play(); hidePauseUI(); hideSettingsUI(); Cursor.visible = false; Cursor.lockState = CursorLockMode.Locked; Time.timeScale = 1; isPaused = false; Debug.Log("Resumed!"); }
    public void Exit() { Application.Quit(); }
    public void Bag() { Debug.Log("This does nothing atm (2)"); }
    public void Team() { Debug.Log("This does nothing atm (1)"); }

}
