using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class HelloWorld : MonoBehaviour
{
    //public GameObject helloText;
    private int speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        print("Hello World");
        //print("Hello World");
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed);
    }
}