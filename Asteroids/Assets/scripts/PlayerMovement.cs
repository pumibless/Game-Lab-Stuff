using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private Rigidbody2D rb;
    private float revSpeed = 100f;
    private float thrust = 5.0f;

    public GameObject playerBeam;
    public GameObject beamSpawner;
    public float laserSpeed = 50f;


    //public Transform Pewpewtrail;


    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0.0f;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            rb.MoveRotation(rb.rotation + revSpeed * Time.fixedDeltaTime);
            Debug.Log("left");
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.MoveRotation(rb.rotation + revSpeed * -Time.fixedDeltaTime);
            Debug.Log("right");
        }

        if (Input.GetKey(KeyCode.UpArrow)) {
            rb.AddForce(transform.up * thrust);
        }

        if (Input.GetKey(KeyCode.Space)) {
            Fire();
        }
    }

    void Fire()
    {
        GameObject Pew = Instantiate(playerBeam,
        beamSpawner.transform.position, transform.rotation) as GameObject;
        Pew.GetComponent<Rigidbody2D>().velocity = transform.up * laserSpeed;

        GameObject.Destroy(Pew, 3);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "AlienBoom") {
            transform.position = Vector3.zero;
        }

        if (collision.gameObject.tag == "Large") {

            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
