using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindThisSpawner : MonoBehaviour
{
    public GameObject[] findThis;
    public GameObject[] spawners;
    public static string currentObj;
    bool countUp;
    public static int i = 0;
    int b;
    int ct;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(i);
        i = Random.Range(0, findThis.Length);
        Vector3 pos = new Vector3(transform.position.x, transform.position.y, 0.1f);
        GameObject obj = Instantiate(findThis[i], pos, Quaternion.identity);
        obj.GetComponent<Jitter>().enabled = false;
        currentObj = findThis[i].transform.tag;
        Debug.Log(currentObj);
        
        spawners[i].GetComponent<CorrectSpawner>().OneSpawn();
        
           
            


        

        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(ct);
        if (ct < spawners.Length-1)
        {
            b += 1;
            ct++;

        }
        if(ct >= 3)
        {
            ct = 5;
        }

        if (b < i || b>i && b < spawners.Length - 1)
        {
            spawners[b].GetComponent<CorrectSpawner>().MultiSpawn();
        }
       
        
       

    }
}
