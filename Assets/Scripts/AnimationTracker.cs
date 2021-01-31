using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTracker : MonoBehaviour
{
    public Animator transitionAnim;
    // Start is called before the first frame update
    void Start()
    {
        CharacterSelect.anim = transitionAnim;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    
    public static void Anim()
    {
        
    }
}
