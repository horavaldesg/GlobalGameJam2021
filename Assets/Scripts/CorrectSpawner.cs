using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CorrectSpawner : MonoBehaviour
{
    int x = 0;
    public GameObject obj;
    float randF;
    public static bool respawn = false;
    string scene;
    int amount = 0;


    void Awake()
    {
        
        amount += 1;
    }

   

   
    //...
    void Start()
    {
        scene = SceneManager.GetActiveScene().name;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (respawn)
        {
            
            //StartCoroutine(loadscene());
            loadNewScene();
            //RemovePrevious();
        }
       
       
    }
    public void loadNewScene()
    {
        if(SceneManager.GetActiveScene().name == "PlayScene")
        {
            SceneManager.LoadScene("PlayScene 1");
        }
        else if(SceneManager.GetActiveScene().name == "PlayScene 1")
        {
            SceneManager.LoadScene("PlayScene");
        }
        
        
        respawn = false;
    }
    IEnumerator loadscene()
    {
        
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(scene);
        Debug.Log("Increase time");
        
        respawn = false;
    }
    public void RemovePrevious()
    {
        for(int i = 1; i< 4; i++)
        {
            string x = i.ToString();
            GameObject[] enemies = GameObject.FindGameObjectsWithTag(x);
            foreach (GameObject enemy in enemies)
                GameObject.Destroy(enemy);
        }
        OneSpawn();
        MultiSpawn();
    }

    public void OneSpawn()
    {
        GameObject spwnObj = Instantiate(obj);
        spwnObj.transform.position = new Vector3(0,0, 0);
    }
    public void MultiSpawn()
    {
        randF = Random.Range(-0.5f, 0.5f);
        for(int i = 0; i < amount; i++)
        {

            GameObject spwnObj = Instantiate(obj);
            spwnObj.transform.position = new Vector3(0, 0, 0);
            
            
        }
    }
}
