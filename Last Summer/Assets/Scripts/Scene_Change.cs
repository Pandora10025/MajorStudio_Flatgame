using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Change : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject gate;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            Debug.Log("Gate");
            SceneManager.LoadScene("My Backyard");
        }



    }*/

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("gate"))
        {
            Debug.Log("Gate");
            SceneManager.LoadScene("My Backyard");
        }
    }
}
