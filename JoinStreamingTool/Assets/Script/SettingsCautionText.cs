using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsCautionText : MonoBehaviour
{
    public Dropdown DropdownObject;
    public Text TextObject;
    public InputField InputFieldObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(DropdownObject.value == 1)
        {
            TextObject.text = "【  !  】"+InputFieldObject.text;
        }
        else
        {
            //test
        }
    }
}
