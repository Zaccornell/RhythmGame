using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//[CreateAssetMenu]
public class ScoreManager : MonoBehaviour
{
    //Singleton
    public static ScoreManager m_instance;
    public static ScoreManager instance
    {
        get
        {
            if (m_instance == null)
            {
                var go = new GameObject();
                m_instance = go.AddComponent<ScoreManager>();

            }
            return m_instance;
        }

    }
    void Awake()
    {
        m_instance = this;
    }

    [SerializeField] int startingScore = 0;
    [SerializeField] Text scoreText;

    public float currentScore { get; set; }


    void Start()
    {
        currentScore = startingScore;
    }

    public void SetScore(int score)
    {
        currentScore = score;
        UpdateScore();
    }

    public void AddScore(int score)
    {
        currentScore += score;
        UpdateScore();
    }

    public void UpdateScore()
    {
        scoreText.text = currentScore.ToString();
    }
}