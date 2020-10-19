using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GerenciadorDeDialogo : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _nomeNpc;
    [SerializeField]
    private TextMeshProUGUI _texto;
    [SerializeField]
    private TextMeshProUGUI _btnContinua;

    [SerializeField]
    private GameObject _caixaDialogo;

    private int contador;
    private Dialogo _dialogoAtual;


    public void Inicializa(Dialogo dialogo)
    {
        contador = 0;
        _dialogoAtual = dialogo;
        ProximaFrase();
    }

    public void ProximaFrase()
    {
        if (_dialogoAtual == null)
            return;

        if (contador == _dialogoAtual.GetFalas().Length)
        {
            _caixaDialogo.gameObject.SetActive(false);
            _dialogoAtual = null;
            contador = 0;
            return;
        }

        _nomeNpc.text = _dialogoAtual.GetFalas()[contador].GetNomeNPC();
        _texto.text = _dialogoAtual.GetFalas()[contador].GetFrase();
        _btnContinua.text = _dialogoAtual.GetFalas()[contador].GetBotaoContinuar();
        _caixaDialogo.gameObject.SetActive(true);
        contador++;
        return;
    }
}
