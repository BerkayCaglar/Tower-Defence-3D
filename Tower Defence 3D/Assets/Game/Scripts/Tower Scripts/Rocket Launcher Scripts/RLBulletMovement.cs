using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RLBulletMovement : TowerManager
{
    private float Speed = 30f;
    private bool Continue = true;
    private ParticleSystem Expolsion;
    private ParticleSystem Flame;
    private void Awake() {
        Expolsion = GameObject.Find("RL Expolsion").GetComponent<ParticleSystem>();
        Flame = GetComponentsInChildren<ParticleSystem>()[0];
    }
    private void Update() {
        if(Continue)
        {
            MoveBullet();
            
            transform.rotation=LookTarget(); // TowerManager.cs
        }
    }
    private void OnCollisionEnter(Collision other) {
        if(Continue)
        {
            Continue=false;  
            Flame.gameObject.SetActive(false);
            StartCoroutine(WaitOneSecond());
        }
    }
    IEnumerator WaitOneSecond()
    {
        Expolsion.Play();
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
    private void MoveBullet()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * Speed);
    }
}
