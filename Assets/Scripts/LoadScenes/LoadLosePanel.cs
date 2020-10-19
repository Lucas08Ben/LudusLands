using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLosePanel : MonoBehaviour
{
    public void goBackToMap()
    {
        SelectWinner.isMachineWon = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("Oiticica02Map");
    }

    public void goBackToMapMissionCarnauba()
    {
        SelectWinner.isMachineWon = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("carnauba03Map");
    }

    public void goBackToMapMissionAngicos()
    {
        SelectWinner.isMachineWon = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("angicos04Map");
    }

    public void goBackToMapMissionJenipapeiro2()
    {
        SelectWinner.isMachineWon = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("Jenipapeiro05Map");
    }
}
