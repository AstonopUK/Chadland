using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightUI : MonoBehaviour
{

    public GameObject[] BasicUIElements;
    public GameObject[] MoveUIElements;
    public GameObject[] BagUIElements;
    public GameObject[] TeamUIElements;

    // Start is called before the first frame update
    void Start()
    {

        BasicUIElements = GameObject.FindGameObjectsWithTag("FightChoice");

        MoveUIElements = GameObject.FindGameObjectsWithTag("FightMoves");
        hideMovesUI();

        BagUIElements = GameObject.FindGameObjectsWithTag("Bag");
        hideBagUI();

        TeamUIElements = GameObject.FindGameObjectsWithTag("Team");
        hideTeamUI();

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            hideMovesUI();
            hideBagUI();
            hideTeamUI();
            showBasicUI();

        }

    }

    public void FightButton() { Debug.Log("Pressed Fight Button!"); hideBasicUI(); hideBagUI(); hideTeamUI(); showMovesUI(); }
    public void TeamButton() { Debug.Log("Pressed Team Button!"); hideBasicUI(); hideMovesUI(); hideBagUI(); showTeamUI(); }
    public void BagButton() { Debug.Log("Pressed Bag Button!"); hideBasicUI(); hideMovesUI(); hideTeamUI(); showBagUI(); }
    public void FleeButton() { Debug.Log("Pressed Flee Button!"); }

    void hideBasicUI()
    {

        foreach (GameObject u in BasicUIElements)
        {

            u.SetActive(false);

        }

    }

    void showBasicUI()
    {

        foreach (GameObject u in BasicUIElements)
        {

            u.SetActive(true);

        }

    }

    void hideMovesUI()
    {

        foreach (GameObject u in MoveUIElements)
        {

            u.SetActive(false);

        }

    }

    void showMovesUI()
    {

        foreach (GameObject u in MoveUIElements)
        {

            u.SetActive(true);

        }

    }

    void hideBagUI()
    {

        foreach (GameObject u in BagUIElements)
        {

            u.SetActive(false);

        }

    }

    void showBagUI()
    {

        foreach (GameObject u in BagUIElements)
        {

            u.SetActive(true);

        }

    }

    void hideTeamUI()
    {

        foreach (GameObject u in TeamUIElements)
        {

            u.SetActive(false);

        }

    }

    void showTeamUI()
    {

        foreach (GameObject u in TeamUIElements)
        {

            u.SetActive(true);

        }

    }

}
