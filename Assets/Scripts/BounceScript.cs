using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceScript : MonoBehaviour
{

    private bool isUp = true;
    private float bounceTimer = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
       
        

    }

    // Update is called once per frame
    void Update()
    {

        bounceTimer -= ((1.0f * Time.deltaTime) * 2);

        if (bounceTimer <= 0.0f)
        {

            bounceTimer = 1.0f;

            if (isUp)
            {

                gameObject.transform.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y - 0.25f);
                isUp = false;

            }
            else if (!isUp)
            {

                gameObject.transform.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y + 0.25f);
                isUp = true;

            }

        }

    }

}
