using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RLBodyFollowSlow : TowerManager
{
    private float LockDistance =8f;
    private void Update()
    {
        transform.rotation=LookTargetSlow(LockDistance); // TowerManager.cs
    }
}
