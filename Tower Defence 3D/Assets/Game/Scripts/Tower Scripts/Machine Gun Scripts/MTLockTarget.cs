using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MTLockTarget : TowerManager
{
    private float LockDistance =6f;
    private MTSpawnBullet mTSpawnBullet;
    private void Awake() {
        mTSpawnBullet = GetComponent<MTSpawnBullet>();
    }
    private void Update() 
    {
        transform.rotation=LookTarget(LockDistance,mTSpawnBullet);// TowerManager.cs
    }
}