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
    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        if (respawn)
        {
            
            StartCoroutine(loadscene());
            //RemovePrevious();
        }
        
        

       
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
        spwnObj.transform.position = new Vector3(Random.Range(-3, 3) + randF, Random.Range(4, -2) + randF, 0);
    }
    public void MultiSpawn()
    {
        randF = Random.Range(-0.5f, 0.5f);
        for(int i = 0; i < 15; i++)
        {

            GameObject spwnObj = Instantiate(obj);
            spwnObj.transform.position = new Vector3(-3, Random.Range(4, -2) + randF, 0);
            
            
        }
    }
}
