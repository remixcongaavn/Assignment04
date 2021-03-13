using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int PinCount = 0;

    public static int CurrentLive = 1;

    public Text scoreText;
    public Text liveText;

    void Start()
    {
        liveText.text = "Life Left: " + CurrentLive.ToString();
    }

    void Update()
    {
        scoreText.text = PinCount.ToString();
    }
}
