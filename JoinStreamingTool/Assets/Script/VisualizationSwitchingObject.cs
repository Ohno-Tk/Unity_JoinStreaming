using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualizationSwitchingObject : MonoBehaviour
{
    public GameObject VisualizationObject;
    
    public void Show()
    {
        VisualizationObject.SetActive (true);
    }
    public void Hide()
    {
        VisualizationObject.SetActive (false);
    }
}
