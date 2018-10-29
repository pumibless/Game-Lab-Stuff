using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour {

    Rigidbody2D rb2D;
    Animator anim;
    SpriteRenderer sr;
    public Sprite lookRight;
    public Sprite lookLeft;

    public float speed = 1f;

    public float jumpForce = 400f;
    public bool grounded;
    public Transform feet;
    public LayerMask whatIsGround;
    public int jumps = 0;
    public int maxJumps;

    // Use this for initialization
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        grounded = Physics2D.OverlapCircle(feet.position, 0.25f, whatIsGround);

        if (grounded)
        {
            jumps = maxJumps;
        }

        var move = new Vector3(Input.GetAxis("Horizontal2"), 0, 0);
        transform.position += move * speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            sr.sprite = lookRight;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            sr.sprite = lookLeft;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && jumps > 0)
        {
            rb2D.AddForce(new Vector2(0, jumpForce));
            jumps--;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Candy")
        {
            Scoring2.score2 += 1;
            Destroy(collision.gameObject);
        }


        if (collision.gameObject.tag == "Chocolate")
        {
            Destroy(collision.gameObject);

        }
    }
}
