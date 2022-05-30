using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RLSpawnBullet : MonoBehaviour
{
    [SerializeField]
    private GameObject rocketBullet;

    private void Start() {
        InvokeRepeating("SpawnRocketBullet",0f,1f);    
    }

    private void SpawnRocketBullet()
    {
        Instantiate(rocketBullet,transform.position,transform.rotation);
    }
}
