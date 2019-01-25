using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float maxS = 11f;
    public Animator a;
    public static int score;
    public bool isRight = true;

	// Use this for initialization
	void Start () {
        a = GetComponent <Animator> ();
        score = 0;

	}
	
	// Update is called once per frame
	void Update () {
        float move = Input.GetAxis("Horizontal");
        a.SetFloat("speed", Mathf.Abs(move));
        /*GetComponent<Rigidbody2D>().velocity = new Vector2(move * maxS,
            GetComponent<Rigidbody2D>().velocity.y);*/
        if (move > 0 && !isRight)
        {
            Flip();
        }
        else
        {
            if (move < 0 && isRight)
            {
                Flip();
            }
        }


    }

    /*void OnMouseDown()
    {
        Rect screenRect = new Rect(0, 0, Screen.width, Screen.height);
        if (!screenRect.Contains(Input.mousePosition))
            return;
    }*/

    void OnMouseDrag()
    {

       
        Rect screenRect = new Rect(0, 0, Screen.width, Screen.height);
        if (!screenRect.Contains(Input.mousePosition))
            return;

        float distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        Vector3 pos_move = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 0.04f, distance_to_screen));
        transform.position = new Vector3(pos_move.x, transform.position.y, pos_move.z);
       
    }



    void Flip()
    {
        isRight = !isRight;
        Vector3 scale = transform.localScale;
        Quaternion rotation = transform.localRotation;
        scale.x *= -1;
        rotation.z *= -1;
        transform.localScale = scale;
        transform.localRotation = rotation;
    }


}
