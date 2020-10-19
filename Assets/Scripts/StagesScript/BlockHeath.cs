using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockHeath : MonoBehaviour
{
    [SerializeField]
    public int vidaTotal;
    [SerializeField]
    public float vidaAtual;

    public bool isDamaged = false;
    public bool isVeryDamaged = false;
    public bool isDestroyed = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (vidaAtual <= (60 * vidaTotal / 100))
        {
            isDamaged = true;
        }

        if (vidaAtual <= (30 * vidaTotal / 100))
        {
            isVeryDamaged = true;
        }
    }

    public void tomarDano(int dano)
    {
        vidaAtual -= dano;

        if (vidaAtual <= 0)
            isDestroyed = true;
    }
}
