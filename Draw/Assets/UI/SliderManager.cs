using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderManager : MonoBehaviour
{
    public static SliderManager instance;
    [SerializeField]
    Slider sliderLine,sliderWater;
    [SerializeField]
    Image fillLine,fillWater;
    [SerializeField]
    Gradient gradientLine;
    private void Awake()
    {
        if(instance ==null)
        {
            instance = this;
        }

    }

    private void Start()
    {
        sliderLine.maxValue = DrawManager.instance.amountLine;
        sliderLine.minValue = 0;
        SetSliderLine(DrawManager.instance.amountLine);
        sliderWater.maxValue = PaddleScript.instance.totalWater;
        sliderWater.minValue = 0;
        SetSliderWater(PaddleScript.instance.totalWater);
    }

    public void SetSliderLine(int value)
    {
        sliderLine.value = value;
        fillLine.color = gradientLine.Evaluate(sliderLine.normalizedValue);
    }

    public void SetSliderWater(int value)
    {
        sliderWater.value = value;
    }


}
