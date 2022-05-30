using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RLBulletMovement : MonoBehaviour
{
    private GameObject Target;
    private float Speed = 40f;
    private bool go = true;
    private float followSpeed = 20f;
    private void Start() {
        FindTargetObject();
    }
    private void Update() {
        if(go)
        {
            MoveBullet();
            LookTarget();
        }
    }
    private void OnCollisionEnter() {
        go=false;
    }
    private void LookTarget()
    {
        Quaternion lookDirection = Quaternion.LookRotation(Target.transform.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation,lookDirection,Time.deltaTime * followSpeed);
    }
    private void FindTargetObject()
    {
        Target = GameObject.Find("Target Cube");
    }
    private void MoveBullet()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * Speed);
    }
}
