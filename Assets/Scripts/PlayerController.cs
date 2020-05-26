using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //Rigidbody2D rig;

    SpriteRenderer spriteR;
    Animator animator;
    [SerializeField] InteractionObjective interact;

    char faceDirection;
    public bool isMoveEnabled = true; 

    //Sprite[] WalkDown = new Sprite[4];
    //float walkCycleTimer = 0.8f;

    //[SerializeField] Sprite wd1;
    //[SerializeField] Sprite wd2;
    //[SerializeField] Sprite wd3;

    // Start is called before the first frame update
    void Start()
    {

        //rig = gameObject.GetComponent<Rigidbody2D>();
        spriteR = gameObject.GetComponent<SpriteRenderer>();
        animator = gameObject.GetComponent<Animator>();

        /*
        WalkDown[0] = wd1;
        WalkDown[1] = wd2;
        WalkDown[2] = wd1;
        WalkDown[3] = wd3;

        StartCoroutine(walkD());
        */

        animator.SetInteger("Walkstate", 0);

    }

    // Update is called once per frame
    void Update()
    {

        if (isMoveEnabled)
        {

            if (Input.GetKeyDown("e"))
            {

                if (faceDirection == 'u')
                {

                    RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up, 1.5f);

                    if (hit.collider != null)
                    {

                        Debug.Log(hit.collider.name);

                        interact.interactCircumstance(hit.collider.name);

                    }

                }
                else if (faceDirection == 'd')
                {

                    RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 1.5f);

                    if (hit.collider != null)
                    {

                        Debug.Log(hit.collider.name);

                        interact.interactCircumstance(hit.collider.name);

                    }

                }
                else if (faceDirection == 'l')
                {

                    RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.left, 1.5f);

                    if (hit.collider != null)
                    {

                        Debug.Log(hit.collider.name);

                        interact.interactCircumstance(hit.collider.name);

                    }

                }
                else if (faceDirection == 'r')
                {

                    RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, 1.5f);

                    if (hit.collider != null)
                    {

                        Debug.Log(hit.collider.name);

                        interact.interactCircumstance(hit.collider.name);

                    }

                }

            }

        }

        if (isMoveEnabled)
        {

            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey("w"))
            {

                gameObject.transform.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y + 0.075f);
                faceDirection = 'u';

                if (animator.GetInteger("Walkstate") != 2)
                {

                    animator.SetInteger("Walkstate", 2);

                }

            }
            else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey("s"))
            {

                gameObject.transform.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y - 0.075f);
                faceDirection = 'd';

                if (animator.GetInteger("Walkstate") != 1)
                {

                    animator.SetInteger("Walkstate", 1);

                }

            }
            else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey("a"))
            {

                gameObject.transform.position = new Vector2(gameObject.transform.position.x - 0.075f, gameObject.transform.position.y);
                faceDirection = 'l';

                if (animator.GetInteger("Walkstate") != 3)
                {

                    animator.SetInteger("Walkstate", 3);

                }

            }
            else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey("d"))
            {

                gameObject.transform.position = new Vector2(gameObject.transform.position.x + 0.075f, gameObject.transform.position.y);
                faceDirection = 'r';

                if (animator.GetInteger("Walkstate") != 4)
                {

                    animator.SetInteger("Walkstate", 4);

                }

            }
            else
            {

                switch (animator.GetInteger("Walkstate"))
                {

                    case 1:
                        animator.SetInteger("Walkstate", 5);
                        break;

                    case 2:
                        animator.SetInteger("Walkstate", 6);
                        break;

                    case 3:
                        animator.SetInteger("Walkstate", 7);
                        break;

                    case 4:
                        animator.SetInteger("Walkstate", 8);
                        break;

                    default:
                        animator.SetInteger("Walkstate", 0);
                        break;

                }

            }

        }
        
    }

    /*
    void walkDown()
    {

        while (walkCycleTimer != 0.0f)
        {

            switch (walkCycleTimer)
            {

                case 0.8f:
                    spriteR.sprite = wd1;
                    break;

                case 0.6f:
                    spriteR.sprite = wd2;
                    break;

                case 0.4f:
                    spriteR.sprite = wd1;
                    break;

                case 0.2f:
                    spriteR.sprite = wd3;
                    break;

                case 0.0f:
                    spriteR.sprite = wd1;
                    break;

                default:
                    spriteR.sprite = wd1;
                    break;

            }

            walkCycleTimer -= (0.2f * Time.deltaTime);

        }

    }
    */

        /*
    IEnumerator walkD()
    {

        int i;
        i = 0;
        while (i < WalkDown.Length - 1)
        {
            spriteR.sprite = WalkDown[i];
            i++;
            yield return new WaitForSeconds(0.1f);
            yield return 0;

        }

    }    
    */

}
