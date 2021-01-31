using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelect : MonoBehaviour
{
    public static Animator anim;
    public AudioClip correct;
    public AudioClip incorrect;
    public AudioClip changeScene;
    AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
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
            audio.clip = correct;
            audio.Play();
            triggerAnim();
            //Time.timeScale = 0;

            //yield return new WaitForSeconds(1.5f);
        }
        else
        {
            audio.clip = incorrect;
            audio.Play();
            Timer.penalty = true;
            //Debug.Log("Wrong Choice");
            Timer.reduceTime -= 2;
        }

    }
    public void triggerAnim()
    {
        audio.clip = changeScene;
        audio.Play();
        anim.SetTrigger("LevelEnd");
        CorrectSpawner.respawn = true;
    }

}
