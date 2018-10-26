using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlientMovement : MonoBehaviour {

    Rigidbody2D rb;
    private float revSpeed = 50f;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        rb.MoveRotation(rb.rotation + revSpeed * Time.fixedDeltaTime);

    }

}
