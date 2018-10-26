using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MakeEnemyRandom : MonoBehaviour
{

    public GameObject enemy;
    float timer = 0;

    GameObject[] platforms;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;

        if (timer >= 1)
        {                                    // xpos(range) , ypos
            GameObject clone = Instantiate(enemy, (new Vector2(Random.Range(-5f, 5f), 15f)), Quaternion.identity);
            clone.transform.localScale = new Vector2(Random.Range(2f, 2f), 2f);
            timer = 0;
        }

        platforms = GameObject.FindGameObjectsWithTag("Enemy");

        foreach (GameObject enemy in platforms)
        {
            enemy.transform.localPosition = new Vector2(enemy.transform.localPosition.x, enemy.transform.localPosition.y - 0.1f);

            if (enemy.transform.localPosition.y < -6)
            {
                Destroy(enemy);
            }
        }
    }

}
