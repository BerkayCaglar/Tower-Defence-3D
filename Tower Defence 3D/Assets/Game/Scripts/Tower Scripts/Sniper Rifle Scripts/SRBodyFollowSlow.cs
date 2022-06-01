using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SRBodyFollowSlow : TowerManager
{
    private void Update()
    {
        transform.rotation=LookTargetSlow(); // TowerManager.cs
    }
}
