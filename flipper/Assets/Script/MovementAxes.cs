using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementAxes : MonoBehaviour
{
    public float movementSpeed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetKeyDown(KeyCode.Q))
        {
                     Vector3 posActuel = transform.position;
                     posActuel = new Vector3(movementSpeed*-1,0,0);
                     
        }/*
        if (Input.GetKeyDown(KeyCode.D))
        {
            Vector3 posActuelD = transform.position;
            posActuelD = new Vector3(X + movementSpeed,0,0);
            
        }*/
      
    }
}
