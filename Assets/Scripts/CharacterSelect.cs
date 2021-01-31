using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelect : MonoBehaviour
{
    public static Animator anim;
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
            //Debug.Log("Correct choice");
            triggerAnim();
            //Time.timeScale = 0;

            //yield return new WaitForSeconds(1.5f);
        }
        else
        {
            //Debug.Log("Wrong Choice");
            Timer.reduceTime -= 2;
        }

    }
    public void triggerAnim()
    {
        anim.SetTrigger("LevelEnd");
        CorrectSpawner.respawn = true;
    }
}
