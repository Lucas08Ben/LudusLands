using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrank : MonoBehaviour
{
    public bool isInFight;

    public float cronometro = 0;

    public int tempoLimite = 0;

    public int dano = 1;

    public GameObject casaDeForcaDoPlayer;

    public GameObject wheel1;
    public GameObject wheel2;
    public GameObject wheelD1;
    public GameObject wheelD2;

    public int forca = 0;



    // Start is called before the first frame update
    void Start()
    {
        isInFight = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(casaDeForcaDoPlayer != null)
        {
            if (distancia() < 10)
                isInFight = true;

            if (isInFight)
            {
                forca = 0;

                if (distancia() > 5)
                {
                    forca = -3;
                }

                if (distancia() < 4)
                {
                    forca = 3;
                }

                this.gameObject.transform.Translate(Vector3.right * 0.002f * forca);

                wheel1.transform.Rotate(Vector3.up * .5f * forca);
                wheel2.transform.Rotate(Vector3.up * .5f * forca);
                wheelD1.transform.Rotate(Vector3.up * .4f * forca);
                wheelD2.transform.Rotate(Vector3.up * .4f * forca);

            }
        }
    }

    private float distancia()
    {
        return gameObject.transform.position.x - casaDeForcaDoPlayer.transform.position.x;
    }

}
