using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemiesMouvement : MonoBehaviour
{
    public Transform destinationTransorm;
    private NavMeshAgent agent; 
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = destinationTransorm.position;
    }
    
    void Update()
    {
        
    }
}
