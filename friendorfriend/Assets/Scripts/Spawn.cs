using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {



    public GameObject Chocolate;

    public GameObject Candy;

    private Transform spawnPoint;
    public GameObject newChocolate;
    public GameObject newCandy;

    public bool candyState = false;

    public static Spawn Instance;

    // Use this for initialization
    void Start () {
        spawnPoint = GetComponent<Transform>();
        makeCandy();

       
    }
	
	// Update is called once per frame
	void Update () {
        if (candyState == false) {
            Invoke("makeCandy", 4f);
        }
	}

    public void makeCandy () {
 
        float candyNum = Random.Range(1, 3);

        candyState = true;

        if (candyNum == 1)
        {
            newChocolate = Instantiate(Chocolate, transform.position, transform.rotation);
            
        }

        if (candyNum == 2)
        {
            newCandy = Instantiate(Candy, transform.position, transform.rotation);
            
        }
    }

}
