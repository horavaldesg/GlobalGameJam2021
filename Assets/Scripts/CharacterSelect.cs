using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        //Debug.Log("You clicked me!");
        //Debug.Log(gameObject.transform.tag);
        if (gameObject.transform.tag == FindThisSpawner.currentObj)
        {
            Debug.Log("Correct choice");
            

            Time.timeScale = 0;
        }
        else
        {
            Debug.Log("Wrong Choice");
            Timer.reduceTime -= 2;
        }


    }
}
