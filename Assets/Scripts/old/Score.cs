using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour

{
    public int scorePoint = 1;
    public Text ScoreText;


    // Use this for initialization
    void Start()
    {

        ScoreText = GetComponent<Text>();
    }

    public void ScoreIncreasing()
    {
        
       
    }
}
