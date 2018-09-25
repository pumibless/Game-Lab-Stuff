using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerCube : MonoBehaviour {

    public float mSpeed;
    public float mJump;
    public bool onGround;
    private Rigidbody rb;

    // Use this for initialization
    void Start () {

        onGround = true;
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(mSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, mSpeed * Input.GetAxis("Vertical") * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && onGround == true) {
            rb.velocity = new Vector3(0f, 1f * mJump, 0f);
            onGround = false;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground")) {
            onGround = true;
        }
    }
}
