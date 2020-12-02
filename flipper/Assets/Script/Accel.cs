using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accel : MonoBehaviour
{
    private Rigidbody rb;
    public float force = 1.0f;


    private void OnTriggerStay(Collider other)
    {
        rb = other.GetComponent<Rigidbody>();

        Vector3 dir = transform.right;
        rb.AddForce(dir * force, ForceMode.Impulse);


    }
}
