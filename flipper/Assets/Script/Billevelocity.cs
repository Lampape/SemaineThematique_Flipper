using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billevelocity : MonoBehaviour
{
    public static int velocityScore;

    // Start is called before the first frame update
    void Start()
    {
        velocityScore = 1;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.T))
        {
            Debug.Log("velocity est a " + velocityScore);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            velocityScore = 1;
            Debug.Log("ici la balle a collisioner avec player est la velo est a zero");
        }
    }
}



