using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiscEffects : MonoBehaviour
{

    [SerializeField] int effectSet;

    private float countdown = 1.0f;
    private bool isUp = false;

    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {

        effectPicker();

    }

    void effectPicker()
    {

        switch (effectSet)
        {

            case 1:
                gameObject.transform.Rotate(new Vector3(0, 0, 1));
                break;

            case 2:

                break;

            case 3:
                if (isUp == true && countdown <= 0.0f)
                {

                    gameObject.transform.position = gameObject.transform.position - new Vector3(0, 0.1f, 0);
                    isUp = false;
                    countdown = 1.0f;

                }
                else if (isUp == false && countdown <= 0.0f)
                {

                    gameObject.transform.position = gameObject.transform.position + new Vector3(0, 0.1f, 0);
                    isUp = true;
                    countdown = 1.0f;

                }

                countdown -= 0.1f;
                break;

        }

    }

}
