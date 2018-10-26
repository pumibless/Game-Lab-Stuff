﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTrail : MonoBehaviour {

    public Transform StartingPoint, EndPoint;
    public int moveSpeed = 200;
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(Vector3.up * Time.deltaTime * moveSpeed);
        Destroy(gameObject, 2);
	}
}
