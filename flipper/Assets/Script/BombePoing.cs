using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombePoing : MonoBehaviour
{
    public Rigidbody Bille;   
    public float radius = 10.0F;
    public float power = 10.0F;
    public float upwardModifier = 1f;

    private void Start()
    {
        //Bille = GetComponent<Rigidbody>()
        Bille.AddExplosionForce(power, transform.position, radius, upwardModifier,
                    ForceMode.Impulse);
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
    }

    
}
