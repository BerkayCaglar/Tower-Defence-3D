using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SRFollowTarget : TowerManager
{
    private float LockDistance =14f;
    private SRSpawnBullet sRSpawnBullet;
    private void Awake() {
        sRSpawnBullet = GetComponentInChildren<SRSpawnBullet>();
    }
    private void Update() 
    {
        transform.rotation=LookTarget(LockDistance,null,null,sRSpawnBullet);// TowerManager.cs
    }
    
}
