using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
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
    [Header("回答正确提示")]
    [SerializeField] GameObject right;

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

        if (items.isFinish == false)
        {
            scoreboard = items.ScoresBoard;

            scoreboard.AddScore(Point);

            items.isFinish = true;
        }

        fatherPanel.SetActive(false);

    }
    public void SecondCancelOption()
    {
        Time.timeScale = 1.0f;

        int Point = 2;

        items = item.GetComponent<Items>();

        if (items.isFinish == false)
        {
            scoreboard = items.ScoresBoard;

            scoreboard.AddScore(Point);

            items.isFinish = true;
        }

        fatherPanel.SetActive(false);
    }

    public void ThirdCancelOption()
    {
        Time.timeScale = 1.0f;

        int Point = 1;

        items = item.GetComponent<Items>();

        if (items.isFinish == false)
        {
            scoreboard = items.ScoresBoard;

            scoreboard.AddScore(Point);

            items.isFinish = true;
        }

        fatherPanel.SetActive(false);
    }
    public void ContinueAndAddScore()
    {
        wrong.SetActive(false);

        right.SetActive(true);

        StartCoroutine(ContinueDelayFunc());
    }
    public void FinishAndAddScore()
    {

        wrong.SetActive(false);

        right.SetActive(true);

        StartCoroutine(FinishDelayFunc());

        
    }

    public void WrongButton()
    {
        wrong.SetActive(true);
    }

    public void FinishAnswer()
    {
        right.SetActive(true);

        StartCoroutine("DelayFunc");

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

    IEnumerator FinishDelayFunc()
    {
        yield return new WaitForSeconds(2);

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

    IEnumerator ContinueDelayFunc()
    {
        yield return new WaitForSeconds(2);

        items = item.GetComponent<Items>();

        scoreboard = items.ScoresBoard;

        scoreboard.AddScore(5);

        nextPanel.SetActive(true);

        gameObject.SetActive(false);

    }
}
