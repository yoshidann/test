using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIController : MonoBehaviour
{

    int score = 0;
    GameObject Point;
    GameObject GameOverText;

    public void GameOver()
    {
        this.GameOverText.GetComponent<Text>().text = "GameOver";
    }
    public void AddScore()
    {
        this.score += 10;
    }

    void Start()
    {
        this.Point = GameObject.Find("Point");
        this.GameOverText = GameObject.Find("GameOverText");
    }

    void Update()
    {
        Point.GetComponent<Text>().text = "Point:" + score.ToString("D4");
    }
}