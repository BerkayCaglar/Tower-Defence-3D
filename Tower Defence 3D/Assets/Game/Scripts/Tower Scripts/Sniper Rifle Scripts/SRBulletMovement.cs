using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SRBulletMovement : TowerManager
{
    private float Speed = 60f;
    private bool Continue = true;
    private void Update() {
        if(Continue)
        {
            MoveBullet();
            
            transform.rotation=LookTarget(); // TowerManager.cs
        }
    }
    private void OnCollisionEnter(Collision other) {
        if(Continue)
            gameObject.GetComponentInChildren<ParticleSystem>().gameObject.SetActive(false);
        Continue=false;   
    }
    private void MoveBullet()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * Speed);
    }
}
