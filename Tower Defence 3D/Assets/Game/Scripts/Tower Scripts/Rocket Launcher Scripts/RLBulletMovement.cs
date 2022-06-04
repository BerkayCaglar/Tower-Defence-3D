using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RLBulletMovement : TowerManager
{
    private float Speed = 40f, LockDistance =8f;
    private bool Continue = true;
    [SerializeField]
    private ParticleSystem Expolsion;
    [SerializeField]
    private GameObject JetEffect;
    private void Update() {
        if(Continue)
        {
            MoveBullet();
            
            transform.rotation=LookTarget(LockDistance); // TowerManager.cs
        }
    }
    private void OnCollisionEnter(Collision other) {
        if(Continue && other.gameObject.CompareTag("Enemy"))
        {
            Continue=false;  
            StartCoroutine(WaitOneSecond());
        }
    }
    IEnumerator WaitOneSecond()
    {
        JetEffect.SetActive(false);
        yield return new WaitForSeconds(1f);
        RemoveTheBullet(gameObject,Expolsion);
    }
    private void MoveBullet()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * Speed);
    }
}
