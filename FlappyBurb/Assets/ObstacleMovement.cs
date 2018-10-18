using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour {

    public Vector2 Move = new Vector2(-5, 0);
    private Rigidbody2D rb;

	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Move;
	}
	
}
