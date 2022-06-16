using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MTLockTargetBody : TowerManager
{
    private float LockDistance =8f;
    private void Update() 
    {
        transform.rotation=LookTargetSlow(LockDistance); // TowerManager.cs
    }
}
