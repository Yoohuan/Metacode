using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToNext : MonoBehaviour
{
    [Space(10)]
    [Header("ÏÂ¸öÃæ°å")]
    [SerializeField] GameObject nextPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            nextPanel.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
