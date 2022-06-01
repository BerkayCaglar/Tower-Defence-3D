using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SRFollowTarget : TowerManager
{
    private void Update()
    {
        transform.rotation=LookTarget(); // TowerManager.cs
    }
}
