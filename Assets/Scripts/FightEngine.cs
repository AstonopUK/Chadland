using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FightEngine : MonoBehaviour
{
    [Header("Player Sprites")]
    [SerializeField] GameObject Player;
    [SerializeField] GameObject Enemy;
    [Space(15)]

    [Header("Moves")]
    [SerializeField] Text Move1;
    [SerializeField] Text Move2;
    [SerializeField] Text Move3;
    [SerializeField] Text Move4;
    [Space(15)]

    [Header("Health Bars")]
    [SerializeField] GameObject PlayerHealthBar;
    [SerializeField] GameObject EnemyHealthBar;
    [Space(15)]

    [Header("Types")]
    [SerializeField] Text pType1;
    [SerializeField] Text pType2;
    [Space(10)]
    [SerializeField] Text eType1;
    [SerializeField] Text eType2;
    [Space(15)]

    [Header("Misc")]
    private bool playerTurn = true;
    private bool ohLordWeZooming = true;
    [SerializeField] private Image blackBox;
    [SerializeField] private Camera mainCam;

    // Start is called before the first frame update
    void Start()
    {

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        //player.isMoveEnabled = false;
        mainCam.fieldOfView = 0.1f;

    }

    // Update is called once per frame
    void Update()
    {

        if (ohLordWeZooming)
        {

            mainCam.fieldOfView += 0.5f;
            Debug.Log(mainCam.fieldOfView);

            if (blackBox.color.a > 0)
            {

                blackBox.color = new Color(blackBox.color.r, blackBox.color.g, blackBox.color.b, blackBox.color.a - 0.05f);

            }

            if (mainCam.fieldOfView >= 60.0f)
            {

                Debug.Log("Stopping...");
                ohLordWeZooming = false;

            }

        }       

    }

    void movePick()
    {



    }

}
