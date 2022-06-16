using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyMovement : MonoBehaviour
{
    private NavMeshAgent EnemyAgent;
    public GameObject target;
    private void Start() 
    {
        EnemyAgent = GetComponent<NavMeshAgent>();
    }
    private void Update() 
    {
        EnemyAgent.SetDestination(target.transform.position);
    }
    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("Target"))
        {
            Destroy(gameObject);
        }    
    }
}