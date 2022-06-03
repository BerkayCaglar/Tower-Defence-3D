using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MTLockTarget : TowerManager
{   
    private float LockDistance =6f;
    private void Awake() {
        
    }
    private void Update() 
    {
        transform.rotation=LookTarget(LockDistance);// TowerManager.cs
    }
}