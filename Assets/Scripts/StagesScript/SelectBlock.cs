using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectBlock : MonoBehaviour
{
    [SerializeField]
    private LayerMask clickbleLayer;

    [SerializeField]
    private GameObject target;

    [SerializeField]
    private GameObject sphereOfHiddeness;

    public GameObject casaDeForça;

    public static GameObject lastSelected = null;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit rayHit;
        
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out rayHit, Mathf.Infinity, clickbleLayer))
        {
            BlockSelection scriptBS = rayHit.collider.GetComponent<BlockSelection>();

            
            scriptBS.hover();

            if (Input.GetMouseButtonDown(0))
            {
                scriptBS.selecionado();
                lastSelected = rayHit.collider.gameObject;
            }
        }
        else
        {
            target.transform.position = sphereOfHiddeness.transform.position;
        }

        if(casaDeForça != null)
        {
            Vector3 position = new Vector3(casaDeForça.transform.position.x + 3, gameObject.transform.position.y, gameObject.transform.position.z);
            gameObject.transform.position = position;
        }
        
        

    }
}
