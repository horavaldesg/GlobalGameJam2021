using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleMenu : MonoBehaviour
{
    public GameObject optionsMenu;
    public GameObject creditsMenu;
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
        //SceneManager.LoadScene("PlayScene");
        optionsMenu.SetActive(false);
        creditsMenu.SetActive(false);
        Debug.Log("GoPlay");
    }

    public void OptionsMenu()
    {
        //SceneManager.LoadScene("OptionsScene");
        optionsMenu.SetActive(true);
        Debug.Log("GoOptions");
    }

    public void CreditsMenu()
    {
        //optionsmenu.SetActive(true);
        Debug.Log("GoCredits");
        creditsMenu.SetActive(true);
    }
}
