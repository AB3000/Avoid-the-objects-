using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeWithCamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.transform.localScale = new Vector3(Camera.main.orthographicSize * Camera.main.aspect, Camera.main.orthographicSize, gameObject.transform.localScale.z);

    }

    // Update is called once per frame
    void Update () {
        gameObject.transform.localScale = new Vector3(Camera.main.orthographicSize * Camera.main.aspect, Camera.main.orthographicSize, gameObject.transform.localScale.z);
    
	}
}
