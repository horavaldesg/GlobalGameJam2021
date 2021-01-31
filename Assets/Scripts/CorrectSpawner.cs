using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectSpawner : MonoBehaviour
{
    int x = 0;
    public GameObject obj;
    float randF;
    bool oneSpawn = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
           
        

       
    }
    public void OneSpawn()
    {
        GameObject spwnObj = Instantiate(obj);
        spwnObj.transform.position = new Vector3(Random.Range(-3, 3) + randF, Random.Range(4, -2) + randF, 0);
    }
    public void MultiSpawn()
    {
        randF = Random.Range(-0.5f, 0.5f);
        for(int i = 0; i < 15; i++)
        {

            GameObject spwnObj = Instantiate(obj);
            spwnObj.transform.position = new Vector3(Random.Range(-3, 3) + randF, Random.Range(4, -2) + randF, 0);
            
        }
    }
}
