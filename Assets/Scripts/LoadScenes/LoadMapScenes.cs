using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class LoadMapScenes : MonoBehaviour
{
    [SerializeField]
    private DetailsManager _manager;

    [SerializeField]
    private Details _details;

    public void Initialize()
    {
        if (_manager == null)
            return;
            
        _manager.inicializa(_details);
    }

    public void Go()
    {
        _manager.irParaMissao();
    }

    public void Abort()
    {
        _manager.abortar();
    }

    public void LoadStarter()
    {
        SceneManager.LoadScene("starter");
    }


}
