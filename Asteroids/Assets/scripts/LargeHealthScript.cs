using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargeHealthScript : MonoBehaviour {

    public int HP = 14;

    void Update()
    {
        if (HP <= 0)
        {
            Destroy(gameObject);
            //Get Score
            Scoring.score += 400;
        }
    }
}
