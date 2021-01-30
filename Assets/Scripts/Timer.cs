using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timer = 20;
    public static float reduceTime;
    TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        reduceTime = timer;
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        reduceTime -= Time.deltaTime;
        text.text = reduceTime.ToString("##");

    }
}
