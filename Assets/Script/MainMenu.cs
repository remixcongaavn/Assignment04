using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{                                             
    public void PlayGame ()
    {   
        Debug.Log("Game Start");
        SceneManager.LoadScene("Game");
        SoundManager.soundIn.Audio.PlayOneShot(SoundManager.soundIn.Click);
    }                

    public void QuitGame ()
    {
        Debug.Log("Quit!!");
        SoundManager.soundIn.Audio.PlayOneShot(SoundManager.soundIn.Click);
        UnityEditor.EditorApplication.isPlaying = false;
    }

    public void MainGame ()
    {   
        Debug.Log("To Main Menu");
        SceneManager.LoadScene("Menu");
        SoundManager.soundIn.Audio.PlayOneShot(SoundManager.soundIn.Click);
    }

}