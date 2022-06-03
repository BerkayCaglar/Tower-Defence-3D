using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RLFollowTarget : TowerManager
{
    private float LockDistance =8f;
    private void Update() 
    {
        transform.rotation=LookTarget(LockDistance);// TowerManager.cs
    }
}