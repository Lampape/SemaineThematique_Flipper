using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoiintGravitation : MonoBehaviour
{
    public Transform target;

    public float multiplicationFactor = 3.0f;
    // Update is called once per frame
    void Update()
    {
          Rigidbody bradFlipper = gameObject.GetComponent<Rigidbody>(); 
              bradFlipper.AddForce((target.position - transform.position) * multiplicationFactor); 
    }
}
