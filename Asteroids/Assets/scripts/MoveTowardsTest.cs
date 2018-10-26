using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsTest : MonoBehaviour {

    public Transform target;
    public float speed;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        float move = speed * Time.deltaTime;
        transform.localPosition = Vector3.MoveTowards(transform.localPosition, target.position, move);
    }
}
