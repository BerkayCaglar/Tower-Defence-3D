using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MTAmmoMovement : MonoBehaviour
{
    private GameObject Target;
    private float speed = 40f;
    private float followSpeed = 20f;
    private bool go = true;

    private void Start() {
        FindTargetObject();
    }
    private void Update() {
        if(go)
        {
            MoveForward();
            LookTarget();
        }    
    }
    private void OnCollisionEnter() {
        go=false;
    }
    private void MoveForward()
    {
        gameObject.transform.Translate(Vector3.forward * speed * Time.deltaTime);
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
}
