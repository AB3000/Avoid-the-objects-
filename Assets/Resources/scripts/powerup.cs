using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup : MonoBehaviour {

    public GameObject fallingShape;
    float speed = 0.0005f;
    bool isTouchingGround; //if true, then reset position of falling object to top 
    float y;
    float yChange;
    public int scoreFall; //score at which object starts falling
    private Sprite[] allSprites;
    public float lowerSpeedLimit;
    public float upperSpeedLimit;
    public int amountToAdd;



    // Use this for initialization
    void Start()
    {
        if (scoreFall == 0)
        {//we didn't set
            scoreFall = -1;
        }

        fallingShape.transform.position = new Vector3(fallingShape.transform.position.x,
                       fallingShape.transform.position.y, fallingShape.transform.position.z);
        y = fallingShape.transform.position.y;
        isTouchingGround = false;
        yChange = 0.1f;
        PlayerController.score = 0;
        //Debug.Log("length is " + allSprites.Length);

        if (System.Math.Abs(lowerSpeedLimit - upperSpeedLimit) < 0.00001)
        {
            lowerSpeedLimit = 0.1f;
            upperSpeedLimit = 0.3f;
        }

    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log("number of sprites are " + allSprites.Length);

        //after player reaches a certain score, the object will fall. Set in scene
        if (PlayerController.score > scoreFall)
        {
            fallingShape.transform.position = new Vector3(fallingShape.transform.position.x,
                       (float)y, fallingShape.transform.position.z);
            y -= yChange;
            if (y < -3.83)
            {
                isTouchingGround = true;

                y = 5.5f;

                yChange = Random.Range(lowerSpeedLimit, upperSpeedLimit);
                fallingShape.transform.position = new Vector3(Random.Range(-(Camera.main.orthographicSize * Camera.main.aspect), (Camera.main.orthographicSize * Camera.main.aspect)),
                 y, fallingShape.transform.position.z);
            }
        }


    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //isTouchingGround = true;
            fallingShape.transform.position = new Vector3(Random.Range(-(Camera.main.orthographicSize * Camera.main.aspect), (Camera.main.orthographicSize * Camera.main.aspect)),
                   5.5f, fallingShape.transform.position.z);
            PlayerController.score += amountToAdd;

        }
    }
}
