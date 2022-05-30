using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerManager : MonoBehaviour
{
    private GameObject Target;
    private float followSpeed = 20f;
    private void Start() 
    {
        FindTargetObject();
    }
    public Quaternion LookTarget()
    {
        Quaternion lookDirection = Quaternion.LookRotation(Target.transform.position - transform.position);

        return Quaternion.Slerp(transform.rotation,lookDirection,Time.deltaTime * followSpeed);
    }
    public Quaternion LookTargetSlow()
    {
        Quaternion Follow = Quaternion.LookRotation(Target.transform.position - gameObject.transform.position);
        return Quaternion.Slerp(transform.rotation,Follow,Time.deltaTime);
    }
    private void FindTargetObject()
    {
       Target = GameObject.Find("Target Cube");
    }
}
