using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public static Music musicIn;
    public AudioSource Audio;

    private void Awake()
    {
        if (musicIn != null && musicIn != this)
        {
            Destroy(this.gameObject);
            return;
        }

        musicIn = this;
        DontDestroyOnLoad(this);
    }

    private void Start()
    {
        Audio = GetComponent<AudioSource>();
    }
}
