using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Vector2 upForce = new Vector2(0, 300);

    private Rigidbody2D rb;
    private Animator anim;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update () {

        if (Input.GetKey(KeyCode.Mouse0))
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(upForce);
            anim.SetTrigger("Swim");

        }else{
            anim.Play ("Idle");
        }

	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "ScoreCollider") {
            ScoreManager.score += 1;
            Debug.Log("hit");
        }

        if (other.gameObject.tag == "Seaweed") {
            
        }
    }
}
