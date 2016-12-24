using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class TextController : MonoBehaviour
{

    public Text text;

	// Use this for initialization
	void Start ()
    {
        // manipulating the text object to hello world
        text.text = "Hello world";
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            text.text = "Space key pressed";
        }
       
	}
}
