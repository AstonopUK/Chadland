using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpotted : MonoBehaviour
{

    [Range (1.0f, 10.0f)]
    public float interactRange;
    public GameObject Player;
    public bool hasFound = false;

    // Start is called before the first frame update
    void Start()
    {

        Player = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {

        if (hasFound == false)
        {

            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, interactRange);

            if (hit.collider != null)
            {

                hasFound = true;
                Debug.Log(hit.collider.name);
                PlayerController playerCont = Player.GetComponent<PlayerController>();
                InteractionObjective playerInt = Player.GetComponent<InteractionObjective>();
                playerCont.isMoveEnabled = false;
                playerInt.interactCircumstance(gameObject.name);

            }


        }
    }

}
