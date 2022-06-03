using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MTAmmoMovement : TowerManager
{
    private float Speed = 40f;
    private float LockDistance =6f;
    private bool Continue = true;
    [SerializeField]
    private ParticleSystem Expolsion;
    [SerializeField]
    private GameObject JetEffect;
    private void Update() {
        if(Continue)
        {
            MoveForward();
            
            transform.rotation=LookTarget(LockDistance); // TowerManager.cs
        }
    }
    private void OnCollisionEnter(Collision other) 
    {
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
    private void MoveForward()
    {
        gameObject.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
    }
}
