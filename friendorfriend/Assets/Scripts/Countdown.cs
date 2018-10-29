using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour {

    float timeLeft = 60f;

    Text text;

	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {

        timeLeft -= Time.deltaTime;
        text.text = "" + timeLeft;

        if ( timeLeft <= 0 && Scoring.score > Scoring2.score2 )
        {
            SceneManager.LoadScene("Player1FOE");
            
        }
        if (timeLeft <= 0 && Scoring2.score2 > Scoring.score)
        {
            SceneManager.LoadScene("Player2FOE");

        }
        if (timeLeft <= 0 && Scoring.score == Scoring2.score2)
        {
            SceneManager.LoadScene("Friend");

        }
    }
}
