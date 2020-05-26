using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpPad : MonoBehaviour
{

    [SerializeField] float locationX;
    [SerializeField] float locationY;

    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {

            GameObject Player = GameObject.FindGameObjectWithTag("Player");
            Player.transform.position = new Vector3(locationX, locationY, 0);

        }

    }

}
