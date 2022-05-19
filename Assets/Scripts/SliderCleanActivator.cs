using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderCleanActivator : MonoBehaviour
{
    public Image _slider;
    public GameObject NextButton;

    void Update()
    {
        if (_slider.fillAmount == 0.50f)
        {
            NextButton.SetActive(true);
        }
    }
}
