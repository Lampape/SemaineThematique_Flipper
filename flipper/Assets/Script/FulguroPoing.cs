using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FulguroPoing : MonoBehaviour
{
    public GameObject Droite;
    public GameObject Gauche;
    public GameObject laBombe;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
        
              GameObject delayObject = Instantiate(laBombe, Gauche.transform.position, Quaternion.identity);
              Destroy(delayObject,1.0f);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            GameObject delayObject = Instantiate(laBombe, Droite.transform.position, Quaternion.identity);
            Destroy(delayObject,1.0f);
        }
    }
}

/*
private void OnCollisionEnter(Collision collision)
{
if (collision.collider.CompareTag("Ground"))
{
    Debug.Log("Boom");
    Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
    Debug.Log(colliders.Length);




    foreach (Collider hit in colliders)
    {
        Rigidbody rb = hit.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.AddExplosionForce(power, transform.position, radius, upwardModifier,
                ForceMode.Impulse);
        }
    }

}

Destroy(gameObject);
}

private void OnDrawGizmos()
{
Gizmos.DrawWireSphere(transform.position, radius);
}
}
*/

