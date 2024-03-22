using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButton : MonoBehaviour
{
    public GameObject BackPackInterFace;

    private bool IfClick;

    public void OpenOrClose()
    {
        IfClick = BackPackInterFace.activeSelf;

        BackPackInterFace.SetActive(!IfClick);
    }
}
