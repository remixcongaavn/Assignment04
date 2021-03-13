using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TimerCountDown : MonoBehaviour
{
    public Text timeDisplay;
    public static int timeLeft = 15;
    private bool takingAway = false;

    void Start()
    {
        timeDisplay.text = "00:" + timeLeft;    
    }

    void Update()
    {
        if (takingAway == false && timeLeft > 0)
        {
            StartCoroutine(TimeTake());
        }

        else if (timeLeft <= 0)
        {
            Debug.Log("Time out.......");
            SceneManager.LoadScene("Quit");
        }
    }

    IEnumerator TimeTake ()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        timeLeft -= 1;

        if (timeLeft < 10)
        {
            timeDisplay.text = "00:0" + timeLeft;
        } else
        {
            timeDisplay.text = "00:" + timeLeft;
        }

        takingAway = false;
    }
}
