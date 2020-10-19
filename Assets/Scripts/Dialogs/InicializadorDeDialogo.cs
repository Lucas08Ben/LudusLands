using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicializadorDeDialogo : MonoBehaviour
{
    [SerializeField]
    private GerenciadorDeDialogo _gerenciador;
    [SerializeField]
    private Dialogo _dialogo;

    public void Inicializar()
    {
        if (_gerenciador == null)
            return;

        _gerenciador.Inicializa(_dialogo);
    }
}
