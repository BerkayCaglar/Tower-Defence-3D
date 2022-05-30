using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RLBodyFollowSlow : TowerManager
{
    private void Update()
    {
        transform.rotation=LookTargetSlow();
    }
}
