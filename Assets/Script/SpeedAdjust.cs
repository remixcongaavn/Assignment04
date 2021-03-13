using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedAdjust : MonoBehaviour
{
    public Slider RotatorSpSlider;

    public Slider PinSpSlider;

    public void RotatorSpeed(float value)
    {
        Rotator.speed = RotatorSpSlider.value;
        Debug.Log("Current Rotator speed: " + Rotator.speed);
    }

    public void PinSpeed(float value)
    {
        Pin.speed = PinSpSlider.value;
        Debug.Log("Current Pin Speed: " + Pin.speed);
    }
}
