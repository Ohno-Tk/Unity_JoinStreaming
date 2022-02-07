using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JoinIDInput : MonoBehaviour {
    // テキストを格納する変数
    public Text text;

    // inputfieldを格納する変数
    private InputField inputField;

    // Use this for initialization
    void Start () {
        // InputFieldコンポーネントを格納
        inputField = GetComponent<InputField>();
    }
    // InputFieldに入力された内容をテキストに表示
    public void DisplayText()
    {
        // テキストに入力内容を表示
        text.GetComponent<Text>().text = inputField.text;
    }
}