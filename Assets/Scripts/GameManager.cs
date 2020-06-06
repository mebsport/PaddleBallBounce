using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Advertisements;


public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    int score;
    public Text scoreText;
    public GameObject gameStartUI;

    string GooglePlay_ID = "3641388";
    bool TestMode = false;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        Advertisement.Initialize(GooglePlay_ID, TestMode);
    }

    void Update()
    {
        
    }

    public void Restart()
    {
        float randomNumber = Random.Range(0, 100);

        if (randomNumber < 34)
        {
            DisplayInterstitialAD();
            SceneManager.LoadScene("Game");
        }
        else
        {
            SceneManager.LoadScene("Game");
        }
    }
    public void ScoreUp()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void GameStart()
    {
        gameStartUI.SetActive(false);
        scoreText.gameObject.SetActive(true);
    }

    private void DisplayInterstitialAD()
    {
        Advertisement.Show();
    }
}
