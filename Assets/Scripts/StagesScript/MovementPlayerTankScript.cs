using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovementPlayerTankScript : MonoBehaviour
{
    public static int forca = 0;

    public GameObject needle;
    public GameObject LeftArrowPointer;
    public GameObject RightArrowPointer;

    public GameObject wheel1;
    public GameObject wheel2;
    public GameObject wheelD1;
    public GameObject wheelD2;

    // Start is called before the first frame update
    void Start()
    {
        forca = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && forca > -5)
        {
            forca--;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && forca < 5)
        {
            forca++;
        }

        if(this.gameObject.transform.position.x < 2.7 && forca < 0)
        {
            forca = 0;
        }

        if(this.gameObject.transform.position.x > 25.7 && forca > 0)
        {
            forca = 0;
        }
        this.gameObject.transform.Translate(Vector3.right * 0.002f * forca);

        wheel1.transform.Rotate(Vector3.up * .5f * forca);
        wheel2.transform.Rotate(Vector3.up * .5f * forca);
        wheelD1.transform.Rotate(Vector3.up * .4f * forca);
        wheelD2.transform.Rotate(Vector3.up * .4f * forca);


        float temp = Mathf.Abs(forca) * 26.6f;

        needle.transform.eulerAngles = Vector3.RotateTowards(needle.transform.eulerAngles, new Vector3(0, 0, 220 - temp), 133, 0.5f);

        if (forca == 0)
        {
            LeftArrowPointer.GetComponent<Image>().color = Color.white;
            RightArrowPointer.GetComponent<Image>().color = Color.white;
        } else if (forca < 0)
        {
            LeftArrowPointer.GetComponent<Image>().color = Color.green;
            RightArrowPointer.GetComponent<Image>().color = Color.white;
        }
        else
        {
            LeftArrowPointer.GetComponent<Image>().color = Color.white;
            RightArrowPointer.GetComponent<Image>().color = Color.green;
        }       

    }
}
