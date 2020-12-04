using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform targetCamera;
    public static int velocityScore;

    void Update()
    {
        transform.LookAt(targetCamera);
    }
    

}
