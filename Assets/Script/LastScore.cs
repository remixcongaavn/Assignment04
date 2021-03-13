using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LastScore : MonoBehaviour
{
    public Text lastScore;
    void Start()
    {
        lastScore.text = "Score: " + Score.PinCount;
    }



}
