using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject characterSpawn;
    public int whichSpawner;
    // Start is called before the first frame update
    void Start()
    {
        if (whichSpawner == 1)
        {
            for (int y = -2; y < 1; y++)
            {
                for (int x = -3; x < 1; x++)
                {
                    Vector3 charcterPos = new Vector3(x, y, transform.position.z) * 1;
                    Instantiate(characterSpawn, charcterPos, Quaternion.identity);
                }
            }
        }
        else if(whichSpawner == 2)
        {
            for (int y = 1; y < 5; y++)
            {
                for (int x = 1; x < 4; x++)
                {
                    Vector3 charcterPos = new Vector3(x, y, transform.position.z) * 1;
                    Instantiate(characterSpawn, charcterPos, Quaternion.identity);
                }
            }
        }
        else if (whichSpawner == 3)
        {
            for (int y = 0; y > -3; y--)
            {
                for (int x = 1; x < 4; x++)
                {
                    Vector3 charcterPos = new Vector3(x, y, transform.position.z) * 1;
                    Instantiate(characterSpawn, charcterPos, Quaternion.identity);
                }
            }
        }
        else if (whichSpawner == 4)
        {
            for (int y = 4; y > 0; y--)
            {
                for (int x = -3; x < 1; x++)
                {
                    Vector3 charcterPos = new Vector3(x, y, transform.position.z) * 1;
                    Instantiate(characterSpawn, charcterPos, Quaternion.identity);
                }
            }
        }


    }

    // Update is called once per frame
    void Update()
    {
       


    }

}
  
