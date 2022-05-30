using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MTLockTarget : MonoBehaviour
{
    private GameObject Target;
    private float Speed = 10f;
    
    private void Start()
    {
        FindTargetObject();
    }
    private void Update() 
    {
        LookTarget();
    }
    private void LookTarget()
    {
        Quaternion lookRotation = Quaternion.LookRotation(Target.transform.position - gameObject.transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation,lookRotation,Time.deltaTime * Speed);
    }
    private void FindTargetObject()
    {
        Target = GameObject.Find("Target Cube");
    }
}
