using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accel : MonoBehaviour
{
    private Rigidbody rb;
    private static bool ImpulseGiven ;

    public int comboGain = 0; // valeur ajoutée au combo quand la bille est renvoyée
    private static int colliderEnterCount ; // aide à déterminer si la bille est dans une zone de détection

    public float steerPower = 1f; //détermine à quel point la trajectoire de la bille est modifiée vers la gauche ou la droite du joueur
    public float force = 2.0f; //force ajoutée par la zone de détection au renvoi de la bille

    private float comboForce; //force ajoutée par le combo au renvoi de la bille
    private float totalForce; //force totale du renvoi de la bille
    

    private void OnTriggerEnter(Collider other)
    {
        colliderEnterCount++;
    }


    private void OnTriggerStay(Collider other)
    {
        rb = other.GetComponent<Rigidbody>();

        Vector3 dirDroite = transform.forward + transform.right * steerPower;
        Vector3 dirGauche = transform.forward - transform.right * steerPower;

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(dirGauche * totalForce, ForceMode.Impulse);

            if (!ImpulseGiven) 
            {
                Billevelocity.velocityScore += comboGain;
                ImpulseGiven = true;
            }
        }

        if (Input.GetKey(KeyCode.Z))
        {
            rb.AddForce(dirDroite * totalForce, ForceMode.Impulse);

            if (!ImpulseGiven)
            {
                Billevelocity.velocityScore += comboGain;
                ImpulseGiven = true;
            }
        }
    }


    private void OnTriggerExit(Collider other)
    {
        colliderEnterCount--;
        //ImpulseGiven = false;
        Debug.Log("comboforce = " + comboForce);
        Debug.Log("entercount = " + colliderEnterCount);
    }


    void Update()
    {
        if(colliderEnterCount == 0)
        {
            ImpulseGiven = false;
        }

        comboForce = Billevelocity.velocityScore + 1;
        totalForce = force * comboForce;
    }
}
