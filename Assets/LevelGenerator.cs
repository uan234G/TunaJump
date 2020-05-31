using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelGenerator : MonoBehaviour
{
    public GameObject platformPrefab;
    public GameObject bigplatformPrefab;
    public GameObject fireplatformPrefab;
    public GameObject player;
    // public GameObject canvas;
    // public GameObject RestartButton;


    public int lv1platforms = 40;
    public int lv2platforms = 40;
    public int lv3platforms = 75;
    public int lv4platforms = 35;
    public float levelWidth = 6f;
    public float minY = .2f;
    public float maxY = 1.5f;

    Vector3 spawnPosition = new Vector3();


    void Start()
    {
        Vector3 spawnPosition = new Vector3();


        for (int i = 0; i < lv1platforms; i++)
        {
            // Debug.Log("Hello World");
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);

            if (Random.Range(1, 5) == 1)
            {
                Instantiate(bigplatformPrefab, spawnPosition, Quaternion.identity);
            }
            else
            {
                Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
            }

        }


        for (int i = 0; i < lv2platforms; i++)
        {
            spawnPosition.y += Random.Range(0.7f, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);

            if (Random.Range(1, 7) == 1)
            {
                Instantiate(bigplatformPrefab, spawnPosition, Quaternion.identity);
            }

            else
            {
                Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
            }

        }

        for (int i = 0; i < lv3platforms; i++)
        {
            spawnPosition.y += Random.Range(1f, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);

            if (Random.Range(1, 10) == 1)
            {
                Instantiate(bigplatformPrefab, spawnPosition, Quaternion.identity);
            }
            else if (Random.Range(1, 10) == 1)
            {
                Instantiate(fireplatformPrefab, spawnPosition, Quaternion.identity);
            }
            else
            {
                Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
            }

        }

        for (int i = 0; i < lv4platforms; i++)
        {
            spawnPosition.y += Random.Range(3f, 3f);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);

            // if (Random.Range(1, 15) == 1)
            // {
            Instantiate(bigplatformPrefab, spawnPosition, Quaternion.identity);
            // }
            // else
            // {
            //     Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
            // }
        }



    }

    void Update()
    {

    }
}
