using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource Audio;
    public AudioClip Click;
    public static SoundManager soundIn;

    private void Awake()
    {
        if (soundIn != null && soundIn != this)
        {
            Destroy(this.gameObject);
            return;
        }

        soundIn = this;
        DontDestroyOnLoad(this);
    }
}
