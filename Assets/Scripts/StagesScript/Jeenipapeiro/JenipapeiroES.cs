using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JenipapeiroES : MonoBehaviour
{
    public GameObject LoadLosePanel;
    private float cronometro = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (SelectWinner.isPlayerWon)
        {
            MovementPlayerTankScript.forca = 0;
            cronometro += Time.deltaTime;
            if (cronometro >= 1)
            {
                SelectWinner.isPlayerWon = false;
                SceneManager.LoadScene("Jenipapeiro06Map");
            }
        }

        if (SelectWinner.isMachineWon)
        {
            MovementPlayerTankScript.forca = 0;
            cronometro += Time.deltaTime;
            if (cronometro >= 1)
            {
                LoadLosePanel.SetActive(true);
                SelectWinner.isMachineWon = false;
            }
        }
    }
}
