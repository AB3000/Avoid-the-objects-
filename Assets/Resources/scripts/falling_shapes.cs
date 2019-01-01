using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falling_shapes : MonoBehaviour {
    
    public GameObject fallingShape;
    float speed = 0.0005f;
    bool isTouchingGround; //if true, then reset position of falling object to top 
    float y;
    float yChange;
    public int scoreFall; //score at which object starts falling
    public int card;
    int number;
    Sprite[] allSprites;

    

    // Use this for initialization
    void Start () {
        fallingShape.transform.position = new Vector3(fallingShape.transform.position.x,
                       fallingShape.transform.position.y, fallingShape.transform.position.z);
        y = fallingShape.transform.position.y;
        isTouchingGround = false;
        yChange = 0.1f;
        PlayerController.score = 0;
        number = int.Parse(GetComponent<SpriteRenderer>().name.Substring(name.Length - 1));
        Debug.Log("number is " + number);
        allSprites = Resources.LoadAll<Sprite>("sprites/abstractshapes" + card);
        //Debug.Log("length is " + allSprites.Length);

    }

    // Update is called once per frame
    void Update()
    {
        if (number > allSprites.Length - 1){
            number = 0;
        }

        //Debug.Log("number of sprites are " + allSprites.Length);

        this.GetComponent<SpriteRenderer>().sprite = allSprites[number];

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
                PlayerController.score++;
                yChange = Random.Range(0.1f, 0.3f);
                fallingShape.transform.position = new Vector3(Random.Range(-(Camera.main.orthographicSize * Camera.main.aspect), (Camera.main.orthographicSize * Camera.main.aspect)),
            y, fallingShape.transform.position.z);
                number++;
            }
        }

       
    }
}
