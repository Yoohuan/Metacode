using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInPanel : MonoBehaviour
{
    [Space(10)]
    [Header("�������")]
    [SerializeField] GameObject fatherPanel;

    [Space(10)]
    [Header("һ�����")]
    [SerializeField] GameObject firstPanel;

    [Space(10)]
    [Header("�¸����")]
    [SerializeField] GameObject nextPanel;

    [Space(10)]
    [Header("��Ʒ")]
    [SerializeField] GameObject item;
    // Start is called before the first frame update
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
        firstPanel.SetActive(true);

        gameObject.SetActive(false);

        fatherPanel.SetActive(false);


    }

    public void Finish()
    {
        Time.timeScale = 1.0f;
        Destroy(item);
        Destroy(fatherPanel);
    }

}
