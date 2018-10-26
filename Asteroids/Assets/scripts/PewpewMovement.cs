using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PewpewMovement : MonoBehaviour {

    public Vector2 speed = new Vector2(50, 50);

    public Vector2 direction = new Vector2(-1, 0);

    private Vector2 movement;
    private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {

        movement = new Vector2(speed.x * direction.x, speed.y * direction.y);
	}

    void FixedUpdate() {

        if (rb == null) {
            rb.velocity = movement;
        }
    }
}
