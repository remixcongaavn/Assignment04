using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundSetting : MonoBehaviour
{
    public Text toggleMusic;

    public void Start()
    {
        if (Music.musicIn.Audio.isPlaying)
        {
            toggleMusic.text = "OFF";
        }
        else
        {
            toggleMusic.text = "ON";
        }
    }
    public void MusicToggle()
    {
        if (Music.musicIn.Audio.isPlaying)
        {
            Music.musicIn.Audio.Pause();
            toggleMusic.text = "ON";
        } else
        {
            Music.musicIn.Audio.Play();
            toggleMusic.text = "OFF";
        }
    }
}
