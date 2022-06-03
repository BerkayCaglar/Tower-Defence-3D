using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SRBodyFollowSlow : TowerManager
{
    private float LockDistance =11f;
    private void Update()
    {
        transform.rotation=LookTargetSlow(LockDistance); // TowerManager.cs
    }
}
