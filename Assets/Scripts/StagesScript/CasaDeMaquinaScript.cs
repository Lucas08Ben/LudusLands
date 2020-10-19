using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasaDeMaquinaScript : MonoBehaviour
{
    public GameObject explodirCasa;
    public GameObject fogo1;

    private bool hasFire1 = false;
    private bool hasFire2 = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        BlockHeath bh = gameObject.GetComponent<BlockHeath>();

        if (bh.isDamaged && !hasFire1)
        {
            Instantiate(fogo1, transform.position + new Vector3(0.2f, 0, -0.5f), Quaternion.identity);
            hasFire1 = true;
        }

        if (bh.isVeryDamaged && !hasFire2)
        {
            Instantiate(fogo1, transform.position + new Vector3(-0.2f, 0, -0.5f), Quaternion.identity);
            hasFire2 = true;
        }

        if (bh.isDestroyed)
        {
            explode();
;       }
    }

    public void explode()
    {
        Instantiate(explodirCasa, transform.position, Quaternion.identity);

        if(gameObject.tag == "Player")
        {
            SelectWinner.isMachineWon = true;
        }

        if(gameObject.tag == "Enemy")
        {
            SelectWinner.isPlayerWon = true;
        }

        Destroy(transform.parent.gameObject);
        
        GameObject [] fires = GameObject.FindGameObjectsWithTag("fire");

        foreach(GameObject fire in fires)
        {
            Destroy(fire);
        }
    }
}
