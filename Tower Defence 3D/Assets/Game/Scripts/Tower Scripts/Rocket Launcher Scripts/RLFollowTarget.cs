using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RLFollowTarget : TowerManager
{
    private void Update()
    {
        transform.rotation=LookTarget(); // TowerManager.cs
    }
}