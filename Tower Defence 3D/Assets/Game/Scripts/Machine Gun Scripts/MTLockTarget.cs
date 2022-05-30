using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MTLockTarget : MonoBehaviour
{
    [SerializeField]
    private GameObject Target;
    private float Speed = 10f;
    
    private void Update() {
        Quaternion lookRotation = Quaternion.LookRotation(Target.transform.position - gameObject.transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation,lookRotation,Time.deltaTime * Speed);
    }
}
