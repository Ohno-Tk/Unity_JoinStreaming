using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// プレイヤーに入力をさせる
public class PlayerInputKey : MonoBehaviour
{
    public KeyCode StartSectionKey = KeyCode.UpArrow;
    public KeyCode SettingKey = KeyCode.Escape;
    public GameObject StartSection;
    public GameObject Setting;
    public GameObject MainLogic;

    // Update is called once per frame
    void Update()
    {
        // 募集開始
        if (Input.GetKey (StartSectionKey))
        {
            Debug.Log("募集を開始します");
            //StartSection.GetComponent<Observer>().StartTimer();
        }
        else if(Input.GetKey (SettingKey))
        {
            Debug.Log("設定を立ち上げます");
            Setting.SetActive (true);
            MainLogic.SetActive (false);
        }
    }
}
