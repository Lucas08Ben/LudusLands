using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSelection : MonoBehaviour
{
    [SerializeField]
    private GameObject selectedTarget;
    [SerializeField]
    private GameObject target;
    [SerializeField]
    private GameObject sphereOfHiddeness;


    public void selecionado()
    {
        target.transform.position = sphereOfHiddeness.transform.position;
        GameObject st = Instantiate(selectedTarget, this.gameObject.transform.position + new Vector3(0, 0, -1), Quaternion.identity);
        Destroy(st, st.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length + .09f);

    }

    public void hover()
    {
        target.transform.position = this.gameObject.transform.position + new Vector3(0, 0, -1);
    }
}
