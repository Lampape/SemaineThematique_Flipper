using System;
using UnityEngine;

public class CollisionSound : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Untagged"))
            FMODUnity.RuntimeManager.PlayOneShot("event:/Boule/boule_collision_obstacle", GetComponent<Transform>().position);
    }
}
