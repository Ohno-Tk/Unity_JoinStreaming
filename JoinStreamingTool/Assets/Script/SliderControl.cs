using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderControl : MonoBehaviour
{
    private Slider SliderObject;
    private float TotalTime;
    public bool UpdateActive = false;
    private bool TimerFinished = false;

    // Start is called before the first frame update
    void Start()
    {
        SliderObject = GetComponent<Slider>();

        SliderObject.value = SliderObject.maxValue;
    }

    // Update is called once per frame
    void Update()
    {
        if(!UpdateActive){return;}

        TimerValueCheck();
        SubtractionTimer();
    }

    public void TimerActive()
    {
        UpdateActive = true;
    }

    // タイマーの終了フラグ取得
    public bool GetTimerFinished()
    {
        return TimerFinished;
    }

    // タイマー設定の初期化
    public void InitializationTimer()
    {
        SliderObject.value = SliderObject.maxValue;
        UpdateActive = false;
        TimerFinished = false;
    }

    public void ChangeValue()
    {
        SliderObject.value = SliderObject.maxValue;
    }

    // タイマーの数値チェック
    private void TimerValueCheck()
    {
        // 0以上
        if(SliderObject.value > 0){return;}

        // 0以下
        SliderObject.value = 0;
        UpdateActive = false;
        TimerFinished = true;
    }

    // タイマーの減算処理
    private void SubtractionTimer()
    {
        TotalTime -= Time.deltaTime;

        SliderObject.value = SliderObject.maxValue + TotalTime;

        /* 0以下の処理
        if(SliderObject.value <= 0)
        {
            //this.transform.SetAsFirstSibling();
            //localScaleChange(1.0f);
        }*/
    }
}
