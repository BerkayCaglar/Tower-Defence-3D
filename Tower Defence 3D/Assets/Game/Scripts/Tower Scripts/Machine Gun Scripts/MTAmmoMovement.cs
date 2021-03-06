using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MTAmmoMovement : TowerManager
{
    private float Speed = 40f;
    private bool Continue = true;
    [SerializeField]
    private ParticleSystem Expolsion;
    [SerializeField]
    private GameObject JetEffect;
    private void Start() 
    {
        Destroy(gameObject,5f);
    }
    private void Update() {
        if(Continue)
        {
            MoveForward();
            
            //transform.rotation=LookTarget(LockDistance); // TowerManager.cs
        }
    }
    private void OnCollisionEnter(Collision other) 
    {
        if(Continue && other.gameObject.CompareTag("Enemy"))
        {
            Continue=false;
            EnemyLife enemyLifeScript=other.gameObject.GetComponent<EnemyLife>();
            enemyLifeScript.lifePoint = enemyLifeScript.lifePoint - 5;
            StartCoroutine(WaitOneSecond());
        }
    }
    IEnumerator WaitOneSecond()
    {
        JetEffect.SetActive(false);
        yield return new WaitForSeconds(1f);
        RemoveTheBullet(gameObject,Expolsion);// TowerManager.cs
    }
    private void MoveForward()
    {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
    }
}
