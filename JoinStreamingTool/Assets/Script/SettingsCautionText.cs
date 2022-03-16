using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsCautionText : MonoBehaviour
{
    public Dropdown DropdownObject;
    public Text TextObject;
    public InputField InputFieldObject;

    // Update is called once per frame
    void Update()
    {

        switch (DropdownObject.value)
        {
            case 0:
                TextObject.text = "【  !  】概要欄を読んでから参加お願いします!";
            break;

            case 1:
                TextObject.text = "【  !  】"+InputFieldObject.text;
            break;

            default:
                Debug.Log("DropdownObject.valueの値が不正です");
            break;
        }
    }
}
