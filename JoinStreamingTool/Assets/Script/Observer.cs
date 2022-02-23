using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Observer : MonoBehaviour
{
    public Slider ChildSlider;
    public Slider NextSlider;

    private SliderControl ChildSliderControl;
    private SliderControl NextControl;

    // Start is called before the first frame update
    void Start()
    {
        ChildSliderControl = ChildSlider.GetComponent<SliderControl>();
        NextControl = NextSlider.GetComponent<SliderControl>();
    }

    // Update is called once per frame
    void Update()
    {
        if(ChildSliderControl.GetTimerFinished())
        {
            EndTimer();
        }
    }

    public void StartTimer()
    {
        LocalScaleChange(1.1f);
        this.transform.SetAsLastSibling();
        ChildSliderControl.TimerActive();
    }

    private void EndTimer()
    {
        LocalScaleChange(1.0f);
        this.transform.SetAsFirstSibling();
        NextControl.TimerActive();
    }

    // Scale変更
    private void LocalScaleChange(float Value)
    {
        this.transform.localScale = new Vector3(Value,Value,1);
    }
}
