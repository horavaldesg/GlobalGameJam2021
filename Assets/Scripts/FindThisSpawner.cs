using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindThisSpawner : MonoBehaviour
{
    public GameObject[] findThis;
    public static string currentObj;
    public static int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(i);
        i = Random.Range(0, findThis.Length);
        Vector3 pos = new Vector3(transform.position.x, transform.position.y, 0.1f);
        Instantiate(findThis[i], pos, Quaternion.identity);
        currentObj = findThis[i].transform.tag;
        Debug.Log(currentObj);
        
    }

    // Update is called once per frame
    void Update()
    {

       

    }
}
