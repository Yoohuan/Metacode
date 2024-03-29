using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class ButtonInPanel : MonoBehaviour
{
    [Space(10)]
    [Header("父级面板")]
    [SerializeField] GameObject fatherPanel;

    [Space(10)]
    [Header("一号面板")]
    [SerializeField] GameObject firstPanel;

    [Space(10)]
    [Header("下个面板")]
    [SerializeField] GameObject nextPanel;

    [Space(10)]
    [Header("回答错误提示")]
    [SerializeField] GameObject wrong;

    [Space(10)]
    [Header("物品")]
    [SerializeField] GameObject item;
    // Start is called before the first frame update
    private PickUp pickup;
    private ScoresBoard scoreboard;
    private Items items;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OpenNextPanel()
    {
        nextPanel.SetActive(true);
        gameObject.SetActive(false);
        
    }

    public void Cancel()
    {
        Time.timeScale = 1.0f;

        gameObject.SetActive(false);

        firstPanel.SetActive(true);

        fatherPanel.SetActive(false);


    }

    public void Finish()
    {
        Time.timeScale = 1.0f;

        pickup = item.GetComponent<PickUp>();

        items = item.GetComponent<Items>();

        scoreboard = items.ScoresBoard;

        int Point = items.point;

        if (pickup != null)
        {
            pickup.PickUpItems(item);

            scoreboard.AddScore(Point);
        }
        else
        {
            scoreboard.AddScore(Point);
        }

        Destroy(item);
        Destroy(fatherPanel);
    }
    public void FirstCancelOption()
    {
        Time.timeScale = 1.0f;

        int Point = 3;

        items = item.GetComponent<Items>();

        scoreboard = items.ScoresBoard;

        scoreboard.AddScore(Point);

    }
    public void SecondCancelOption()
    {
        Time.timeScale = 1.0f;

        int Point = 2;

        items = item.GetComponent<Items>();

        scoreboard = items.ScoresBoard;

        scoreboard.AddScore(Point);
    }
    public void ContinueAndAddScore()
    {
        items = item.GetComponent<Items>();

        scoreboard = items.ScoresBoard;

        scoreboard.AddScore(5);

        nextPanel.SetActive(true);

        gameObject.SetActive(false);
    }
    public void FinishAndAddScore()
    {
        Time.timeScale = 1.0f;

        pickup = item.GetComponent<PickUp>();

        items = item.GetComponent<Items>();

        scoreboard = items.ScoresBoard;

        if (pickup != null)
        {
            pickup.PickUpItems(item);
        }

        scoreboard.AddScore(5);

        Destroy(item);

        Destroy(fatherPanel);
    }

    public void WrongButton()
    {
        wrong.SetActive(true);
    }
}
