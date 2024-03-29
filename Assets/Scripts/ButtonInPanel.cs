using System.Collections;
using System.Collections.Generic;
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

        Destroy(item);
        Destroy(fatherPanel);
    }

    public void WrongButton()
    {
        wrong.SetActive(true);
    }
}
