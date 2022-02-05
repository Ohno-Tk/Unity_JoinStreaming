using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderTest : MonoBehaviour
{
    public Slider TimerGauge;

    private float TotalTime;

    void Start()
    {
        TimerGauge.value = TimerGauge.maxValue;

        localScaleChange(1.1f);

        this.transform.SetAsLastSibling();
    }

    // Update is called once per frame
    void Update()
    {
        TotalTime -= Time.deltaTime;

        TimerGauge.value = TimerGauge.maxValue + TotalTime;

        // 0以下の処理
        if(TimerGauge.value <= 0)
        {
            this.transform.SetAsFirstSibling();
            localScaleChange(1.0f);
        }

        //Debug.Log ((int)TotalTime);
    }

    public void TimerGaugeMaxValueChange(int Value)
    {
        TimerGauge.maxValue = Value;
    }

    // ゲージのScale変更
    private void localScaleChange(float Value)
    {
        this.transform.localScale = new Vector3(Value,Value,1);
    }
}
