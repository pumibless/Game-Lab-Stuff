using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienSpawn : MonoBehaviour {

    public GameObject Large;
    float timer = 0;

    public Transform target;
    public float speed;

    // Use this for initialization
    void Start () {


    }

    // Update is called once per frame
    void Update () {

        timer += Time.deltaTime;
        if (timer >= 5){

            GameObject clone = Instantiate(Large, new Vector3(Random.Range(-13f, 13f), Random.Range(-9f, 9f), 0), Quaternion.Euler(0, 0, Random.Range(-0.0f, 359.0f)));
            float move = speed * Time.deltaTime;
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, target.position, move);

            timer = 0;

 
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "AlienBoom")
        {
            Destroy(collision.gameObject);
        }
    }


}
