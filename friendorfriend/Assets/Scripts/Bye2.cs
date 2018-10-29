using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bye2 : MonoBehaviour {

    Rigidbody2D rb;

    public float speed = 50f;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        
        rb.velocity = Vector3.right * speed;
        
    }
}
