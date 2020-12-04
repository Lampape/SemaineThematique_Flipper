using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accel : MonoBehaviour
{
    private Rigidbody rb;
    public float force = 2.0f; //force du renvoi de la bille
    public float steerPower = 1f; //détermine à quel point la trajectoire de la bille est modifiée vers la gauche ou la droite du joueur

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Collision en cours");

        rb = other.GetComponent<Rigidbody>();

        Vector3 dirDroite = transform.forward + transform.right * steerPower;
        Vector3 dirGauche = transform.forward - transform.right * steerPower;
        //Vector3 dirFace = transform.forward;
        //rb.AddForce(dir * force, ForceMode.Impulse);

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(dirGauche * force, ForceMode.Impulse);
            Debug.Log("renvoi à gauche");
        }

        if (Input.GetKey(KeyCode.Z))
        {
            rb.AddForce(dirDroite * force, ForceMode.Impulse);
            Debug.Log("renvoi à droite");
        }

        

    }
}
