using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InicializaDialogTio : MonoBehaviour
{

    private GameObject Tio;

    [SerializeField]
    private GameObject _caixaDialogo;
    // Start is called before the first frame update
    void Start()
    {
        Tio = GameObject.Find("Tio");
        Tio.GetComponent<InicializadorDeDialogo>().Inicializar();
    }

    // Update is called once per frame
    void Update()
    {
        if(!_caixaDialogo.activeSelf)
            SceneManager.LoadScene("Oiticica02Map");
    }
}
