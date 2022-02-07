using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelColorChange : MonoBehaviour
{
    public void Show()
    {
        GetComponent<Image>().color = new Color32 (255, 0, 0, 255);
    }

    public void Hide()
    {
        GetComponent<Image>().color = new Color32 (255, 0, 0, 0);
    }
}
