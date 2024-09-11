using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio_Volume : MonoBehaviour
{
    public float radioInFrontDistance;

    public LayerMask radioLayerMask;
    //private float facing = 1;

    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateDistance();

        if (radioInFrontDistance > 10)
        {
            //this.GetComponent<AudioSource>().;
        }
    }

// call every frame to determine the distance of the radio from the player
private void UpdateDistance()
    {
        radioInFrontDistance = Vector2.Distance(this.transform.position, player.transform.position);

        Debug.Log(radioInFrontDistance);
    }
}
