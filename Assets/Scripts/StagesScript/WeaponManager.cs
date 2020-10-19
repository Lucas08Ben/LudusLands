using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{

    public GameObject explodir;
    public GameObject basicFire;
    public GameObject intenseFire;

    private GameObject BF;
    private GameObject IF;


    private bool hasBasicFire = false;
    private bool hasIntenseFire = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BlockHeath bh = gameObject.GetComponent<BlockHeath>();

        if (bh.isDamaged && !hasBasicFire)
        {
            BF = Instantiate(basicFire, transform.position + new Vector3(0f, 0, -0.5f), Quaternion.identity);
            hasBasicFire = true;
        }

        if (bh.isVeryDamaged && !hasIntenseFire)
        {
            IF = Instantiate(intenseFire, transform.position + new Vector3(0f, 0, -0.5f), Quaternion.identity);
            hasIntenseFire = true;
        }

        if (bh.isDestroyed)
        {
            explode();
        }
    }

    void explode()
    {
        Destroy(IF);
        Destroy(BF);
        GameObject explo = Instantiate(explodir, transform.position, Quaternion.identity);
        Destroy(transform.parent.gameObject);
        Destroy(explo, 1f);
    }
}
