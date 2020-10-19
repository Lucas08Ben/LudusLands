using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGun : MonoBehaviour
{
    public float speed = 1f;
    private int dano;
    public Rigidbody rb;
    public GameObject bulletExplosion;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter(Collider collision)
    {
        BlockHeath blk = collision.GetComponentInChildren<BlockHeath>();
        if(blk != null)
        {
            blk.tomarDano(dano);
            GameObject BE = Instantiate(bulletExplosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Destroy(BE, 1f);
        }

        
    }

    public void SetDano(int dano)
    {
        this.dano = dano;
    }

}
