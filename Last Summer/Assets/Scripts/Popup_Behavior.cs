using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Popup_Behavior : MonoBehaviour
{
    public GameObject text;

    float pos_x;
    float pos_y;

    //create sprite renderer with a rectangle the size of the given text, 
    //set text and rectangele to positions above this game object 

    // Start is called before the first frame update
    void Start()
    {
        pos_x = transform.position.x; 
        pos_y = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            text.SetActive(true);
            text.GetComponent<Transform>().transform.localPosition = new Vector3(pos_x, pos_y+3, 0);
        }
    }
}
