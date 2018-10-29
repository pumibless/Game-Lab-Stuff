using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChocolateScoring : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player") {

            Scoring.score += 2;
            Scoring2.score2 += 2;

        }
    }
}
