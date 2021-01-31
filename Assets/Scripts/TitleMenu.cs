using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PlayMenu()
    {
        SceneManager.LoadScene("PlayScene");
        //optionsmenu.SetActive(false);
    }

    public void OptionsMenu()
    {
        SceneManager.LoadScene("OptionsScene");
    }

    public void CreditsMenu()
    {
        //optionsmenu.SetActive(true);
    }
}
