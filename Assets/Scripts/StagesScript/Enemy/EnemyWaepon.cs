using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWaepon : MonoBehaviour
{
    public GameObject casaDeForcaDoPlayer;

    public GameObject Cannon;

    public Transform firePoint;

    public GameObject bulletPrefab;

    public int dano = 1;
    private float cronometro;
    public float tempoLimite;

    public GameObject enemyTank;

    private bool isInAtack = false;

    // Start is called before the first frame update
    void Start()
    {
        cronometro = 0;

    }

    // Update is called once per frame
    void Update()
    {
        isInAtack = enemyTank.GetComponent<EnemyTrank>().isInFight;
        if (isInAtack)
        {
            cronometro += Time.deltaTime;
            if (cronometro >= tempoLimite)
            {
                cronometro = 0;
                if(casaDeForcaDoPlayer != null)
                    ShootDirectional();
            }
        }

    }

    public void ShootDirectional()
    {
        Cannon.transform.LookAt(casaDeForcaDoPlayer.transform.position, firePoint.position);

        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bullet.GetComponent<BulletGun>().SetDano(dano);
    }
}
