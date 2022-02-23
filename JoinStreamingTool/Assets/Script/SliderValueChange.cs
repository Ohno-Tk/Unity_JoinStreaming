using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderValueChange : MonoBehaviour
{
    public Slider SliderObject;
    private Text TextObject;

    // Start is called before the first frame update
    void Start()
    {
        TextObject = this.GetComponent<Text>();
        TextObject.text = SliderObject.value + "秒";
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void TextChange()
    {
        TextObject.text = SliderObject.value + "秒";
    }
}
