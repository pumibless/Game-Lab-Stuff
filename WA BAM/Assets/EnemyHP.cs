using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour {

    public int HP = 2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(HP <= 0)
        {
            Destroy(gameObject);
            //Get Score
            ScoringManager.score += 100;
        }
	}

}
