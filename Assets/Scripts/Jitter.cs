using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jitter : MonoBehaviour
{
    int x = 10;
    int y = 25;
    public float speed = 2f;
    Vector3 orgPos;
    Vector2 direction;
    Vector2 movementPerSecond;
    // Start is called before the first frame update
    void Start()
    {
        orgPos = transform.position;
        direction = new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f)).normalized;
        movementPerSecond = direction * speed;

    }

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector2(transform.position.x + (movementPerSecond.x * Time.deltaTime),
        transform.position.y + (movementPerSecond.y * Time.deltaTime));
        //transform.position = new Vector2(transform.position.x + (movementPerSecond.x * Time.deltaTime), transform.position.y);
        transform.Rotate(0,0,2);
        //transform.position += Vector3.right * speed * Time.deltaTime;
        //transform.position += Vector3.up * speed * Time.deltaTime;

        if (transform.position.x > x || transform.position.x < -x || transform.position.y > y || transform.position.y < -y + 2)
        {
            transform.position = new Vector3(orgPos.x , orgPos.y , transform.position.z);
        }


    }
    
}
