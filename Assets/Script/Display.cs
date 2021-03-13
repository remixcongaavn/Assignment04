using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Display : MonoBehaviour
{
    public static int lastPlayLive = 1;
    public static int lastCountTime = 15;

    public Dropdown liveDropDown;
    public Dropdown timeDropDown;

    public static string theName;
    public GameObject inputField;
    public GameObject textDisplay;

    public void StoreName ()
    {
        theName = inputField.GetComponent<Text>().text;
        textDisplay.GetComponent<Text>().text = "Welcome " + theName + " to the game!!!!";
    }

    public void changeLives()
    {
        switch (liveDropDown.value)
        {
            default:
                Score.CurrentLive = 1;
                lastPlayLive = 1;
                break;

            case 0:
                Score.CurrentLive = 1;
                lastPlayLive = 1;
                break;

            case 1:
                Score.CurrentLive = 2;
                lastPlayLive = 2;
                break;

            case 2:
                Score.CurrentLive = 3;
                lastPlayLive = 3;
                break;
        }
    }

    public void changeTime()
    {
        switch (timeDropDown.value)
        {
            default:
                TimerCountDown.timeLeft = 15;
                lastCountTime = 15;
                break;

            case 0:
                TimerCountDown.timeLeft = 15;
                lastCountTime = 15;
                break;

            case 1:
                TimerCountDown.timeLeft = 20;
                lastCountTime = 20;
                break;

            case 2:
                TimerCountDown.timeLeft = 30;
                lastCountTime = 30;
                break;
        }
    }
}