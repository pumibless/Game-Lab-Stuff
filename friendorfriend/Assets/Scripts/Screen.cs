using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screen : MonoBehaviour {

    // Update is called once per frame
    void Update()
    {

        // Teleport the game object
        if (transform.position.x > 22)
        {

            transform.position = new Vector3(-22, transform.position.y, 0);

        }
        else if (transform.position.x < -22)
        {
            transform.position = new Vector3(22, transform.position.y, 0);
        }

        else if (transform.position.y > 15)
        {
            transform.position = new Vector3(transform.position.x, -15, 0);
        }

        else if (transform.position.y < -15)
        {
            transform.position = new Vector3(transform.position.x, 15, 0);
        }
    }
}
