using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static int Score;
    public string ScoreString = "Score";

    public Text TextScore;
    

    Text text;

    public static GameController GameControler;

    void Awake()
    {
        GameControler = this;
        text = GetComponent<Text>();
        Score = 0;
    }
    void Update()
    {
        TextScore.text = ScoreString + Score.ToString();
    }
}
