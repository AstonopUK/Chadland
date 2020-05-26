using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    string[] warpLocations = new string[20];
    [SerializeField] int locationIdentifier;
    [SerializeField] GameObject player;

    // Start is called before the first frame update
    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player");

        warpLocations[0] = "TheAbyss";
        warpLocations[1] = "ChadfordShopEntrance";
        warpLocations[2] = "GeneralShop";
        warpLocations[3] = "Travelodge";
        warpLocations[4] = "ChadvilleShop";
        warpLocations[5] = "NewBark";
        warpLocations[6] = "Intro";
        warpLocations[7] = "ChadHouseStart";
        warpLocations[8] = "ChadHouse";
        warpLocations[9] = "ChadhouseEntrance";

    }

    // Update is called once per frame
    void Update()
    {
       
        

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            LoadNextScene();
        }
    }

    void LoadNextScene()
    {

        switch (warpLocations[locationIdentifier])
        {

            case "ChadfordShopEntrance":
                player.transform.position = new Vector3(5.2f, 4.8f, 0);
                SceneManager.LoadScene("Chadford");
                break;

            case "Travelodge":
                SceneManager.LoadScene("Travelodge");
                break;

            case "GeneralShop":
                player.transform.position = new Vector3(-0.5f, -3f, 0);
                SceneManager.LoadScene("HealthStore");
                break;

            case "NewBark":
                player.transform.position = new Vector3(-7f, -1.5f, 0);
                SceneManager.LoadScene("NewBark");
                break;

            case "Intro":
                player.transform.position = new Vector3(0, 0, 0);
                SceneManager.LoadScene("Intro");
                break;

            case "ChadHouseStart":
                player.transform.position = new Vector3(4, 16.5f, 0);
                SceneManager.LoadScene("ChadHouse");
                break;

            case "ChadHouse":
                player.transform.position = new Vector3(-22.6f, 17.5f, 0);
                SceneManager.LoadScene("ChadHouse");
                break;

            case "ChadhouseEntrance":
                player.transform.position = new Vector3(22.9f, 4.9f, 0);
                SceneManager.LoadScene("Chadford");
                break;

            default:

                break;

        }

    }

}
