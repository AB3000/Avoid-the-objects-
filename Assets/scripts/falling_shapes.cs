using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falling_shapes : MonoBehaviour {
    
    public GameObject fallingShape;
    public static int score = 0; 
    float speed = 0.0005f;
    bool isTouchingGround;
    float y;
    float yChange;



	// Use this for initialization
	void Start () {
        fallingShape.transform.position = new Vector3(fallingShape.transform.position.x,
                       fallingShape.transform.position.y, fallingShape.transform.position.z);
        y = fallingShape.transform.position.y;
        isTouchingGround = false;
        yChange = 0.1f;
	}
	
	// Update is called once per frame
	void Update () {
            fallingShape.transform.position = new Vector3(fallingShape.transform.position.x,
                       (float) y, fallingShape.transform.position.z);
            y -= yChange;
            if(y < - 3.83){
                isTouchingGround = true;
                 y = 5.5f;
                score++;
            yChange = Random.Range(0.1f, 0.3f);
                fallingShape.transform.position = new Vector3(Random.Range(-10.0f, 10.0f),
                    y, fallingShape.transform.position.z);
                 
            }

	}
}
