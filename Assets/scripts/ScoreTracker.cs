using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour {

    public Text Score;
	// Use this for initialization
	void Start () {
        Score.text = "0";
	}
	
	// Update is called once per frame
	void Update () {
        Score.text = PlayerController.score.ToString();
    }
}
