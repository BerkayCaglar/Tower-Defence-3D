using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RLFollowTarget : TowerManager
{
    private float LockDistance =10f; 
    private RLSpawnBullet rLSpawnBullet;
    private void Awake() {
        rLSpawnBullet = GetComponentInChildren<RLSpawnBullet>();
    }
    private void Update() 
    {
        transform.rotation=LookTarget(LockDistance,null,rLSpawnBullet); // TowerManager.cs
    }
}