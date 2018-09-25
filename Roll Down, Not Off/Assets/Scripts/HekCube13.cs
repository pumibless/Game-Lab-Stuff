using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HekCube13 : MonoBehaviour
{

    public float speed;// when variable public, it creates a variable where we can type in our Inspector
    public float moveSpeed;
    public float turnSpeed;

    //void Awake(){} called first

    // Use this for initialization
    void Start()
    {
        moveSpeed = 5f;
        turnSpeed = 20f;
        speed = 8f;

    }

    // Update is called once per frame
    //void FixedUpdate(){} always run at the proper speed. consistent. used for physics calculations
    void Update()
    {

        //this sets the position equal to a new value instead of adding a vector3
        transform.position = new Vector3(Mathf.PingPong(Time.time * speed, 6), transform.position.y, transform.position.z);
        //ping pong changes value btwn 0 and a number you set, we used 3

        Vector3 start = new Vector3(15.5f, 202.5f, 94f);
        Vector3 end = new Vector3(-1.5f, 202.5f, 94f);

        //use lerping to move btwn start and end position
        Vector3 moving = Vector3.Lerp(start, end, Mathf.PingPong(Time.time, 1));
        transform.position = moving;

    }
}
