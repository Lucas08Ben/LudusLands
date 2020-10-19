using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TNTBlock : MonoBehaviour
{
    public GameObject explodirCasa;

    public GameObject housePower;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BlockHeath bh = gameObject.GetComponent<BlockHeath>();
        if (bh.isDestroyed)
        {
            explode();
        }
    }

    private void explode()
    {
        Instantiate(explodirCasa, transform.position, Quaternion.identity);
        housePower.GetComponent<CasaDeMaquinaScript>().explode();
    }
}
