using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoresBoard : MonoBehaviour
{
    public Text ScoreText;
    public int Scores;
    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = "1";
    }
    public void AddScore()
    {
        Scores += 1;

        ScoreText.text = Scores.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        ScoreText.text = Scores.ToString();
    }
}
