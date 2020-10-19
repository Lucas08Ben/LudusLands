using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockArm : MonoBehaviour
{   
    public Animator animacao;

    public GameObject explodir;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BlockHeath bh = gameObject.GetComponent<BlockHeath>();

        if (bh.isDamaged)
        {
            animacao.SetBool("IsDamaged", true);
        }

        if (bh.isVeryDamaged)
        {
            animacao.SetBool("IsVeryDamaged", true);
        }

        if (bh.isDestroyed)
        {
            explode();
        }
    }

    void explode()
    {
        GameObject explo = Instantiate(explodir, transform.position, Quaternion.identity);
        Destroy(gameObject);
        Destroy(explo, 1f);
    }


}
