using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jitter : MonoBehaviour
{
    int x = 10;
    int y = 25;
    public int speed = 2;
    Vector3 orgPos;

    // Start is called before the first frame update
    void Start()
    {
        orgPos = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
        transform.position += Vector3.up * speed * Time.deltaTime;

        if (transform.position.x > x || transform.position.x < -x || transform.position.y > y || transform.position.y < -y + 2)
        {
            transform.position = new Vector3(orgPos.x, orgPos.y, transform.position.z);
        }


    }
    
}
