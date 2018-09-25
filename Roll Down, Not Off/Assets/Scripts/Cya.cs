using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cya : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        //   Debug.Log("i touched something!!");
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "sphere")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }


    }

    void OnCollisionStay(Collision other)
    {
        //   Debug.Log("i'm still touching!!");
        if (other.gameObject.tag == "sphere")
            gameObject.GetComponent<Renderer>().material.color = Color.green;

    }

    void OnCollisionExit(Collision other)
    {
        //   Debug.Log("i'm hekkin done");
        if (other.gameObject.tag == "sphere")
            gameObject.GetComponent<Renderer>().material.color = Color.red;

    }

    public float upforce;

    void OnMouseDown()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * upforce, ForceMode.Impulse);
      
    }


    void OnTriggerEnter(Collider other)
    {

    }

    void OnTriggerStay(Collider other)
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * upforce);
     
    }

    void OnTriggerExit(Collider other)
    {

    }
}

