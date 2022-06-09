using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretUIMovement : MonoBehaviour
{
    private Transform cam;
    private void Start() 
    {
        cam = GameObject.Find("Main Camera").transform;    
    }

    [System.Obsolete]
    private void Update() 
    {
        if(gameObject.active)
        {
            Quaternion lookCamera = Quaternion.LookRotation(transform.position - cam.position);
            transform.rotation = Quaternion.Slerp(transform.rotation,lookCamera,Time.deltaTime);    
        }
    }
}