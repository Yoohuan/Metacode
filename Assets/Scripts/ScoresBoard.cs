using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoresBoard : MonoBehaviour
{
    public Text ScoreText;
    public int Scores;
    public GameObject CutScene1;
    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = "0";
    }
    public void AddScore(int Point)
    {
        Scores += Point;

        ScoreText.text = Scores.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        ScoreText.text = Scores.ToString();

        Scene currentScene = SceneManager.GetActiveScene();

        int sceneIndex = currentScene.buildIndex;

        if (Scores >= 18 && sceneIndex == 1)
        {
            CutScene1.SetActive(true);
        }
        if (Scores >= 22 && sceneIndex == 2)
        {
            CutScene1.SetActive(true);
        }
    }
    public void NextClass()
    {
        SceneManager.LoadScene(2);
    }
    public void Cancel()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        int sceneIndex = currentScene.buildIndex;

        SceneManager.LoadScene(sceneIndex);
    }
    public void BackMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
