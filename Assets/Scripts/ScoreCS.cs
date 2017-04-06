using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCS : MonoBehaviour {
    public int score;
    public GameObject scoreTextObj;
    Text scoreText;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        scoreText = scoreTextObj.GetComponent<Text>();
        scoreText.text = "Score:" + score.ToString();
    }
}
