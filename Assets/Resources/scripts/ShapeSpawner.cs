using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeSpawner : MonoBehaviour {

    GameObject spawningObstacles;
    public GameObject prefab;

   

    // Use this for initialization
    void Start () {

        for (int i = 0; i < 1; i++)
        {
            spawningObstacles = Instantiate(prefab) as GameObject;
            Vector3 position = new Vector3(1, 1, 1);
            Quaternion rotation = new Quaternion(1, 1, 1, 1);
            GameObject obj = Instantiate(prefab, position, rotation) as GameObject;

        }

    }
	
	// Update is called once per frame
	void Update () {
       
    }
}
