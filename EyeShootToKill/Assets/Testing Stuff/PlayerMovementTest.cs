using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementTest : MonoBehaviour
{

    public float speed = 1.0f;

    void Update()
    {
        var move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        transform.position += move * speed * Time.deltaTime;

    }
}
