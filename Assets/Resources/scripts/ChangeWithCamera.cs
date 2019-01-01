using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeWithCamera : MonoBehaviour {

    void Awake()
    {

        this.gameObject.transform.localScale = new Vector3(1, 1, 1);

        float width = gameObject.GetComponent<SpriteRenderer>().sprite.bounds.size.x;
        float height = gameObject.GetComponent<SpriteRenderer>().sprite.bounds.size.y;

        float worldScreenHeight = Camera.main.orthographicSize * 2.0f;
        float worldScreenWidth = worldScreenHeight / Screen.height * Screen.width;

        this.gameObject.transform.localScale = new Vector3(worldScreenWidth / width, worldScreenHeight / height, 1);
    }

}
