using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MTBodyMovement : TowerManager
{
    private Vector3 startPos;
    private void Start() {
        startPos = transform.position;
    }
    public void ResetBody()
    {
        transform.position = ResetYourBody(gameObject,startPos); // TowerManager.cs
    }
}
