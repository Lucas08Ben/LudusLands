using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadStarterContents : MonoBehaviour
{
    public GameObject CreditsPanel;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void showCreditsPanel()
    {
        CreditsPanel.SetActive(true);
    }

    public void hiddenCreditsPanel()
    {
        CreditsPanel.SetActive(false);
    }

    public void LoadMap()
    {
        SceneManager.LoadScene("MapCutOficina01");
    }

    public void QuitGame()
    {
        Debug.Log("Game Quited!!!");
        Application.Quit();
    }
}
