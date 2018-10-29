using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring2 : MonoBehaviour
{

    public static int score2;

    Text text;

    void Awake()
    {
        text = GetComponent<Text>();
        score2 = 0;
    }


    void Update()
    {

        text.text = "" + score2;
    }
}