using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnd = false;

    public Rotator rotator;
    public Spawner spawner;

    public Animator animator;

    public void EndGame()
    {
        if (gameHasEnd)
            return;
        gameHasEnd = true;

        rotator.enabled = false;
        spawner.enabled = false;

        animator.SetTrigger("EndGame");

        Debug.Log("End Game!!");
    }
    
    public void RestartLevel ()
    {
        SceneManager.LoadScene("Quit");
    }
}
