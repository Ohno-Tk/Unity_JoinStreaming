using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingText : MonoBehaviour
{

    public InputField SettingInputField;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Text> ().text = SettingInputField.text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
