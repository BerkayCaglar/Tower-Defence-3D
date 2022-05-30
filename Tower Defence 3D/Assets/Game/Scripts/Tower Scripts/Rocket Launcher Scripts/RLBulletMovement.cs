using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RLBulletMovement : TowerManager
{
    private float Speed = 40f;
    private bool go = true;
    private void Update() {
        if(go)
        {
            MoveBullet();
            
            transform.rotation=LookTarget(); // TowerManager.cs
        }
    }
    private void OnCollisionEnter() {
        go=false;
    }
    private void MoveBullet()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * Speed);
    }
}
