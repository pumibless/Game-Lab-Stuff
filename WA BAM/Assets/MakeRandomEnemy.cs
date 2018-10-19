using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MakeRandomEnemy : MonoBehaviour
{

    public GameObject enemy;
    float timer = 0;

    GameObject[] Enemies;

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
            GameObject clone = Instantiate(enemy, (new Vector2(Random.Range(-12f, 12f), 14f)), Quaternion.identity);
            clone.transform.localScale = new Vector2(Random.Range(3f, 3f), 3f);
            timer = 0;
        }

        Enemies = GameObject.FindGameObjectsWithTag("Enemy");

        foreach (GameObject enemy in Enemies)
        {
            enemy.transform.localPosition = new Vector2(enemy.transform.localPosition.x, enemy.transform.localPosition.y - 0.1f);

            if (enemy.transform.localPosition.y < -11f)
            {
                Destroy(enemy);
            }
        }
    }

}
