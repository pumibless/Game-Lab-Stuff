using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PewpewScript : MonoBehaviour
{

    public int DMG;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Large")
        {
            other.GetComponent<LargeHealthScript>().HP -= DMG;

            Debug.Log("HIT");
        }
    }
}
