using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RLBodyFollowSlow : MonoBehaviour
{
    private GameObject Target;
    private void Start() {
        FindTargetObject();
    }
    private void Update()
    {
        LookTarget();
    }
    private void FindTargetObject()
    {
        Target = GameObject.Find("Target Cube");
    }
    private void LookTarget()
    {
        Quaternion Follow = Quaternion.LookRotation(Target.transform.position - gameObject.transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation,Follow,Time.deltaTime);
    }
}
