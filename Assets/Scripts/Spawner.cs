using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] characterSpawn;
    public int whichSpawner;
    int i = 0;
    int iR;
    // Start is called before the first frame update
    void Start()
    {
        
        if (whichSpawner == 1)
        {
            for (int y = -2; y < 1; y++)
            {
                for (int x = -3; x < 1; x++)
                {
                    while(i == FindThisSpawner.i)
                    {
                        i = Random.Range(0, characterSpawn.Length);
                    }
                   
                    Vector3 charcterPos = new Vector3(x, y, transform.position.z) * 1;
                    Instantiate(characterSpawn[i], charcterPos, Quaternion.identity);
                    Debug.Log(i);
                }


            }
        }
        else if (whichSpawner == 2)
        {

            for (int y = 1; y < 5; y++)
            {
                for (int x = 1; x < 4; x++)
                {
                    while (i == FindThisSpawner.i)
                    {
                        i = Random.Range(0, characterSpawn.Length);
                    }
                    Vector3 charcterPos = new Vector3(x, y, transform.position.z) * 1;
                    Instantiate(characterSpawn[i], charcterPos, Quaternion.identity);
                    Debug.Log(i);


                }
            }
        }
        else if (whichSpawner == 3)
        {

            for (int y = 0; y > -3; y--)
            {
                for (int x = 1; x < 4; x++)
                {
                    while (i == FindThisSpawner.i)
                    {
                        i = Random.Range(0, characterSpawn.Length);
                    }
                    Vector3 charcterPos = new Vector3(x, y, transform.position.z) * 1;
                    Instantiate(characterSpawn[i], charcterPos, Quaternion.identity);
                    Debug.Log(i);
                }

            }
        }
        else if (whichSpawner == 4)
        {

            for (int y = 4; y > 0; y--)
            {
                for (int x = -3; x < 1; x++)
                {
                    while (i == FindThisSpawner.i)
                    {
                        i = Random.Range(0, characterSpawn.Length);
                    }

                   
                    Vector3 charcterPos = new Vector3(x, y, transform.position.z) * 1;
                    Instantiate(characterSpawn[i], charcterPos, Quaternion.identity);
                    Debug.Log(i);
                }

            }
        }
        else if(whichSpawner == 5)
        {
            iR = FindThisSpawner.i;
            Vector3 characterPosRight = new Vector3(Random.Range(-3, 2), Random.Range(4, -2), transform.position.z);
            Instantiate(characterSpawn[iR], characterPosRight, Quaternion.identity);
            Debug.Log(i);

        }

    }

    // Update is called once per frame
    void Update()
    {
       


    }

}
  
