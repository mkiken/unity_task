using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBarController : MonoBehaviour
{
    private Slider slider = null;
    // Use this for initialization
    void Start()
    {
        getSlider();
        InvokeRepeating("setRandomValue", 1.0f, 5.0f);
    }

    void setRandomValue()
    {
        iTween.ValueTo(gameObject, iTween.Hash(
    "from", slider.value,
    "to", Random.Range(slider.minValue, slider.maxValue),
    "time", 3.0f,
    "easetype", iTween.EaseType.linear,
    "onupdate", "setValue",
    "onupdatetarget", gameObject
));
    }

    void setValue(float val)
    {
        Slider slider = GetComponent<Slider>();
        slider.value = val;
    }

    Slider getSlider()
    {
        if (slider == null)
        {
            slider = GetComponent<Slider>();
        }

        return slider;
    }
}
