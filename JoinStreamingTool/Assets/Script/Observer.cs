using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Observer : MonoBehaviour
{

    public Slider ChildSlider;
    public GameObject NextSecttion;
    private SliderControl ChildSliderControl;
    public bool UpdateFlag = false;

    // Start is called before the first frame update
    void Start()
    {
        ChildSliderControl = ChildSlider.GetComponent<SliderControl>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!UpdateFlag){return;}

        if(ChildSliderControl.TimerFinished())
        {
            LocalScaleChange(1.0f);
            this.transform.SetAsFirstSibling();
            UpdateFlag = false;

            NextSecttion.GetComponent<Observer>().SetUpdateFlag(true);
            return;
        }

        LocalScaleChange(1.1f);
        this.transform.SetAsLastSibling();
        ChildSliderControl.SubtractionTimer();
    }

    public void SetUpdateFlag(bool flag)
    {
        UpdateFlag = flag;
    }

    // Scale変更
    private void LocalScaleChange(float Value)
    {
        this.transform.localScale = new Vector3(Value,Value,1);
    }
}
