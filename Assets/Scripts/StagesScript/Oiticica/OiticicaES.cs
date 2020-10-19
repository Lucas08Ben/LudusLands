using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OiticicaES : MonoBehaviour
{
    public GameObject LoadLosePanel;

    public GameObject dialogo;

    public GameObject dialogBox;

    public bool isDialogStarted;

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
            dialogo.transform.position = GameObject.Find("Camera").transform.position + new Vector3(0, -0.1f, 2);
            if (!isDialogStarted)
            {
                isDialogStarted = true;
                gameObject.GetComponent<InicializadorDeDialogo>().Inicializar();
            }

            if(!dialogBox.activeSelf && isDialogStarted)
            {
                SelectWinner.isPlayerWon = false;
                SceneManager.LoadScene("Carnauba03Map");
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
