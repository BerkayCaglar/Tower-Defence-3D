using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MTLockTargetBody : MonoBehaviour
{
    [SerializeField]
    private GameObject Target;
    private float Speed = 3f;
    
    private void Update() {
        LookTarget();
    }
    private void LookTarget()
    {
        Quaternion lookRotation = Quaternion.LookRotation(Target.transform.position - gameObject.transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation,lookRotation,Time.deltaTime * Speed);
    }
}
