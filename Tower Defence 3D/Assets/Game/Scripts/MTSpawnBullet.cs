using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MTSpawnBullet : MonoBehaviour
{
    [SerializeField]
    private GameObject bullet;
    void Start()
    {
        InvokeRepeating("SpawnBullet",0f,1f);
    }

    private void SpawnBullet()
    {
        Instantiate(bullet,new Vector3(0.25f,1.2f,1.3f),gameObject.transform.rotation);
    }
}   
