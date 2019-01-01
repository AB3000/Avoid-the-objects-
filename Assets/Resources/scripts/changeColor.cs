using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour {


    public float speed = 1.0f;
    public Color startColor;
    public Color endColor;

	// Use this for initialization
	void Start () {

        //making color completely opaque
        //startColor.a = endColor.a = 255;
	}
	
	// Update is called once per frame
	void Update () {
        //cycling between the 2 colors 
        GetComponent<Renderer>().material.color = Color.Lerp(startColor, endColor, Mathf.PingPong(Time.time * speed, 1.0f));
	}
}
