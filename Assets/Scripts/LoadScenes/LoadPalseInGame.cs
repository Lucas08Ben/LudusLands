using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadPalseInGame : MonoBehaviour
{
    public GameObject PausePanel;
    public GameObject tank;
    public bool isPaused;
    public int forca = 0;

    void Update()
    {
        if (isPaused)
        {
            MovementPlayerTankScript.forca = 0;
        }
    }

    public void resume()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        MovementPlayerTankScript.forca = forca;

    }

    public void pause()
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        forca = MovementPlayerTankScript.forca;
    }

    public void exitOiticicaStage()
    {
        SceneManager.LoadScene("Oiticica02Map");
        Time.timeScale = 1f;
    }

    public void exitCarnaubaStage()
    {
        SceneManager.LoadScene("Carnauba03Map");
        Time.timeScale = 1f;
    }
}
