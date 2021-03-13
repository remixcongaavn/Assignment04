﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pin : MonoBehaviour
{
    private bool isPinned = false;

    public static float speed = 20f;
    public Rigidbody2D rb;

    void Update()
    {
        if (!isPinned)
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Rotator")
        {
            transform.SetParent(col.transform);
            Score.PinCount++;
            isPinned = true;
        }
        
        if (col.tag == "Pin")
        {
            Score.CurrentLive -= 1;
            SceneManager.LoadScene("Game");
            
        } else if (Score.CurrentLive <= 0)
        {
            FindObjectOfType<GameManager>().EndGame();
            SceneManager.LoadScene("Quit");
        }
    }
}
