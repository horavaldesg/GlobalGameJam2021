using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectSpawner : MonoBehaviour
{
    int x = 0;
    public GameObject obj;
    float randF;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        randF = Random.Range(-0.5f, 0.5f);
        if (x < 15)
        {
            
            GameObject spwnObj = Instantiate(obj);
            spwnObj.transform.position = new Vector3(Random.Range(-3, 3) + randF, Random.Range(4, -2) + randF, 0);
            x++;
        }
    }
}
