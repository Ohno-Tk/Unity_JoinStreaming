using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderControl : MonoBehaviour
{
    private Slider SliderObject;
    private float TotalTime;

    private bool TimerUpdateFlag=false;

    // Start is called before the first frame update
    void Start()
    {
        SliderObject = GetComponent<Slider>();

        SliderObject.value = SliderObject.maxValue;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SetTimerUpdateFlag(bool flag)
    {
        TimerUpdateFlag = flag;
    }

    public bool GetTimerUpdateFlag()
    {
        return TimerUpdateFlag;
    }

    // タイマーの数値チェック
    public bool TimerFinished()
    {
        // 0以上
        if(SliderObject.value > 0){return false;}

        // 0以下
        SliderObject.value = 0;
        TimerUpdateFlag = true;

        return true;
    }

    // タイマーの減算処理
    public void SubtractionTimer()
    {
        TotalTime -= Time.deltaTime;

        SliderObject.value = SliderObject.maxValue + TotalTime;
    }
}
