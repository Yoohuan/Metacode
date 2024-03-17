using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    // Start is called before the first frame update
    [Space(10)]
    [Header("��Ʒ����")]
    [SerializeField] string name;

    [Space(10)]
    [Header("��Ʒ�÷�")]
    [SerializeField] int point;

    [Space(10)]
    [Header("��Ʒ����")]
    [SerializeField] GameObject panel;

    bool isTouch;
    public ScoresBoard ScoresBoard;

    void Start()
    {
        isTouch = false;
    }

    void Update()
    {
        OpenPanel();
    }
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        GetPlayerIn(other);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        GetPlayerOut(other);
    }

    void GetPlayerIn (Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isTouch = true;
        }
    }

    void GetPlayerOut (Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isTouch = false;
        }
    }

    void OpenPanel ()
    {
        if (isTouch && Input.GetKeyDown(KeyCode.F))
        {
            ScoresBoard.AddScore(point);
            Time.timeScale = 0.0f;
            panel.SetActive(true);
        }
    }
}
