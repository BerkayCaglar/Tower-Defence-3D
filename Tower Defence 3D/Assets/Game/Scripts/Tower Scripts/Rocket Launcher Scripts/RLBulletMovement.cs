using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RLBulletMovement : TowerManager
{
    private float Speed = 30f;
    private bool Continue = true;
    private ParticleSystem Expolsion;
    private ParticleSystem Flame;
    private MeshRenderer RLBulletMainPart;
    private MeshRenderer RLBulletPart1;
    private MeshRenderer RLBulletPart2;
    private MeshRenderer RLBulletPart3;
    private BoxCollider RLBulletMainCollider;
    private void Awake() {
        FindVariables();
    }
    private void Update() {
        if(Continue)
        {
            MoveBullet();
            
            transform.rotation=LookTarget(); // TowerManager.cs
        }
    }
    private void OnCollisionEnter(Collision other) {
        if(Continue && other.gameObject.CompareTag("Enemy"))
        {
            Continue=false;  
            Flame.gameObject.SetActive(false);
            StartCoroutine(WaitOneSecond());
        }
    }
    IEnumerator WaitOneSecond()
    {
        yield return new WaitForSeconds(1f);
        RemoveBullet();
    }
    private void MoveBullet()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * Speed);
    }
    private void RemoveBullet()
    {
        RLBulletMainPart.enabled = false;
        RLBulletPart1.enabled = false;
        RLBulletPart2.enabled = false;
        RLBulletPart3.enabled = false;
        Expolsion.transform.parent=null;
        Expolsion.transform.localScale= new Vector3(0.5f,0.5f,0.5f);
        RLBulletMainCollider.enabled=false;
        Expolsion.Play();
        Destroy(gameObject,1f);
    }
    private void FindVariables()
    {
        Expolsion = GetComponentsInChildren<ParticleSystem>()[0];
        Flame = GetComponentsInChildren<ParticleSystem>()[1];

        RLBulletMainPart = GetComponent<MeshRenderer>();
        RLBulletPart1 = GetComponentsInChildren<MeshRenderer>()[1];
        RLBulletPart2 = GetComponentsInChildren<MeshRenderer>()[2];
        RLBulletPart3 = GetComponentsInChildren<MeshRenderer>()[3];
        RLBulletMainCollider = GetComponent<BoxCollider>();
    }
}
