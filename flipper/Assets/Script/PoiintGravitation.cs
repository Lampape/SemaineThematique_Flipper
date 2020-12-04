using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoiintGravitation : MonoBehaviour
{
    public Transform target;
    public float maxVelocity = 40f;

    public float multiplicationFactor = 3.0f;
    // Update is called once per frame
    void Update()
    {
        Rigidbody bille = gameObject.GetComponent<Rigidbody>(); 
        bille.AddForce((target.position - transform.position) * multiplicationFactor);

        if (bille.velocity.magnitude > maxVelocity)
        {
            bille.velocity = bille.velocity.normalized * maxVelocity;
        }
        //Debug.Log(bille.velocity.magnitude);
    }
}
