using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MTLockTargetBody : TowerManager
{
    private void Update() 
    {
        transform.rotation=LookTargetSlow(); // TowerManager.cs
    }
}
