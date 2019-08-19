using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public bool isPause = false;

    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }

    public void Pause()
    {
        isPause = true;
        if (isPause)
        {
            Time.timeScale = 0f;
        }
    }

    public void Resume()
    {
        Time.timeScale = 1f;
    }
}
