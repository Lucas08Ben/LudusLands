using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firepoint;

    public GameObject bulletPrefab;

    public GameObject cannon;

    public int dano = 1;
    private float cronometro;
    public float tempoLimite;

    // Start is called before the first frame update
    void Start()
    {
        cronometro = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if(SelectBlock.lastSelected != null)
        {
            cronometro += Time.deltaTime;
            if (cronometro >= tempoLimite)
            {
                cronometro = 0;
                ShootDirectional();
            }
        }
        
    }

    public void ShootDirectional()
    {
        cannon.transform.LookAt(SelectBlock.lastSelected.transform.position, firepoint.position);

        GameObject bullet = Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
        bullet.GetComponent<BulletGun>().SetDano(dano);
    }

 
}
