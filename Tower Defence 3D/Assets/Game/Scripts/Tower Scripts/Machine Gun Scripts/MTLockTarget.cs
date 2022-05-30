using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MTLockTarget : TowerManager
{   
    private void Update() 
    {
        transform.rotation=LookTarget(); // TowerManager.cs
    }
}