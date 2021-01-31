using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioSource audioSource;
    public static bool stopPlaying;
    public static bool reloadScene =false;
    public static float amountContainer = 1;
    //public static AudioClip sceneAudio;
    // Start is called before the first frame update
    void Start()
    {
        //amountContainer = CorrectSpawner.amount;
    }
    private void Update()
    {
        
        //if(audioSource.clip.name != sceneAudio.name)
        //{
        //    audioSource.clip = sceneAudio;
        //}
       
        if (stopPlaying)
        {
            StopMusic();
        }
        else
        {
            PlayMusic();
        }
    }
    // Update is called once per frame


    private void Awake()
    {
        stopPlaying = false;
       
            DontDestroyOnLoad(transform.gameObject);
            audioSource = GetComponent<AudioSource>();
            audioSource.Play();
        //audioSource.clip = sceneAudio;
        
       
    }

    public void PlayMusic()
    {
        if (audioSource.isPlaying) return;
        audioSource.Play();
        //audioSource.clip = sceneAudio;
    }

    public void StopMusic()
    {
        audioSource.Stop();
    }
    
}
