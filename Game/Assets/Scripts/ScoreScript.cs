using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

    public static int scoreValue = 0;
    Text score;
    ScoreScript scoreScript;

    // Use this for initialization
    public void Start () {
        score = GetComponent<Text>();

    }
	
	// Update is called once per frame
	public void Update () {
        score.text = "Score:           " + scoreValue;
	}
}
