using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour {

    Vector3 MousePos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        MousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y);
        Vector3 lookPos = Camera.main.ScreenToWorldPoint(MousePos);
        lookPos = lookPos - transform.position;
        float angle = Mathf.Atan2(lookPos.y, lookPos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);


    }
}
