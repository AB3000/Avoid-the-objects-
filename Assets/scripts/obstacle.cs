using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class obstacle : MonoBehaviour {


	void OnTriggerEnter2D(Collider2D other)
    {
		if(other.tag == "Player"){
			Debug.Log("Game ended");
            SceneManager.LoadScene("GameOver");
		}
    }
}
