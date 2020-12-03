using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemie : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BilleFlipper"))
        {
            Destroy(other.gameObject);
        }
    }
}

