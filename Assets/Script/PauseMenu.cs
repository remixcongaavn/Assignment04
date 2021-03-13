using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                SoundManager.soundIn.Audio.PlayOneShot(SoundManager.soundIn.Click);
                Resume();
            } else
            {
                SoundManager.soundIn.Audio.PlayOneShot(SoundManager.soundIn.Click);
                Pause();
            }
        }
    }

    public void Resume ()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1;
        GameIsPaused = false;
    }

    void Pause ()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        SoundManager.soundIn.Audio.PlayOneShot(SoundManager.soundIn.Click);
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
        Debug.Log("Loading Menu!!");
    }

    public void QuitGame()
    {
        SoundManager.soundIn.Audio.PlayOneShot(SoundManager.soundIn.Click);
        Application.Quit();
        Debug.Log("Quit Game!!!!");
    }

    public void saveGame()
    {
        SoundManager.soundIn.Audio.PlayOneShot(SoundManager.soundIn.Click);
        PlayerPrefs.SetInt("score", Score.PinCount);
        PlayerPrefs.SetInt("live", Score.CurrentLive);
        PlayerPrefs.SetString("name", Display.theName);
        Debug.Log("Saved game:  Score: " + Score.PinCount + " Live: " + Score.CurrentLive + "Name: " + Display.theName);
    }

    public void loadGame ()
    {
        SoundManager.soundIn.Audio.PlayOneShot(SoundManager.soundIn.Click);
        Score.PinCount = PlayerPrefs.GetInt("score");
        Score.CurrentLive = PlayerPrefs.GetInt("live");
        Display.theName = PlayerPrefs.GetString("name");
        SceneManager.LoadScene("Game");
        Resume();

        Debug.Log("Loading save game...... Score: " + Score.PinCount + " Live: " + Score.CurrentLive + "Name: " + Display.theName);
    }
}
