using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class script : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKey(KeyCode.W))
        {
            this.transform.localPosition += new Vector3(0, .05f, 0);

        }*/
       /* if (Input.GetKey(KeyCode.S))
        {
            this.transform.localPosition += new Vector3(0, -.05f, 0);

        }*/
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.localPosition += new Vector3(.02f, 0, 0);
            transform.Rotate(Vector3.back);

        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.localPosition += new Vector3(-.02f, 0, 0);
            transform.Rotate(Vector3.forward);
        }
    }
}
