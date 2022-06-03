using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SRFollowTarget : TowerManager
{
    private float LockDistance =11f;
    private void Update() 
    {
        transform.rotation=LookTarget(LockDistance);// TowerManager.cs
    }
    
}
