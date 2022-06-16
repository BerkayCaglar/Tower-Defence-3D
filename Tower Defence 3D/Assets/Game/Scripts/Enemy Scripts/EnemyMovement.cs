using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyMovement : MonoBehaviour
{
    private NavMeshAgent EnemyAgent;
    private GameObject Target;
    private void Start() 
    {
        Target = GameObject.Find("Target");
        EnemyAgent = GetComponent<NavMeshAgent>();
    }
    private void Update() 
    {
        EnemyAgent.SetDestination(Target.transform.position);
    }
    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("Target"))
        {
            Destroy(gameObject);
        }    
    }
}