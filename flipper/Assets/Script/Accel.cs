using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accel : MonoBehaviour
{
    private static bool ImpulseGiven ;
    private static int colliderEnterCount ;
    
    
    private Rigidbody rb;
    public float force = 2.0f; //force du renvoi de la bille
    public float steerPower = 1f; //détermine à quel point la trajectoire de la bille est modifiée vers la gauche ou la droite du joueur
    public float velocityfloat;
    public float combosVelocityForce;
    public int gainVelocity = 0; // valeur qui donne la velocité a la balle et l'effet combos

    private void OnTriggerStay(Collider other)
    {
        rb = other.GetComponent<Rigidbody>();

        Vector3 dirDroite = transform.forward + transform.right * steerPower;
        Vector3 dirGauche = transform.forward - transform.right * steerPower;
        //Vector3 dirFace = transform.forward;
        //rb.AddForce(dir * force, ForceMode.Impulse);

        if (Input.GetKeyDown(KeyCode.A) && !ImpulseGiven)
        {
            rb.AddForce(dirGauche * combosVelocityForce, ForceMode.Impulse);
            ImpulseGiven = true;
            Billevelocity.velocityScore += gainVelocity;
        }

        if (Input.GetKeyDown(KeyCode.Z) && !ImpulseGiven)
        {
            rb.AddForce(dirDroite * combosVelocityForce, ForceMode.Impulse);
            ImpulseGiven = true;
            Billevelocity.velocityScore += gainVelocity;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        ImpulseGiven = false;
        colliderEnterCount--;
    }

    private void OnTriggerEnter(Collider other)
    {
        colliderEnterCount++;
       /*Debug.Log("Collision en cours");
        if (Input.GetKey(KeyCode.A))
        {
            Billevelocity.velocityScore += gainVelocity;
        }

        if (Input.GetKey(KeyCode.Z))
        {
            Billevelocity.velocityScore += gainVelocity;
        }*/
    }

void Update()
    {
        if(colliderEnterCount == 0)
        {
            ImpulseGiven = false;
        }
        combosVelocityForce = force + velocityfloat;
        velocityfloat = Billevelocity.velocityScore;
    }


}
