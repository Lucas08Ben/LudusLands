using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AlexDialog : MonoBehaviour
{
    [SerializeField]
    private GameObject _caixaDialogo;

    private float cronometro;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<InicializadorDeDialogo>().Inicializar();
        cronometro = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!_caixaDialogo.activeSelf)
        {
            cronometro += Time.deltaTime;
            if (cronometro >= 1)
            {
                SceneManager.LoadScene("starter");
            }
        }
            
    }
}
