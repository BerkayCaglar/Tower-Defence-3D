using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SRHeadMovement : TowerManager
{
    [SerializeField]
    private GameObject SRBody;
    private Vector3 targetPosition;
    private void Start() 
    {
        SetTargetPosition();
    }
    private void Update() 
    {
       ResetYourHead();
    }
    private void SetTargetPosition()
    {
        targetPosition = SRBody.transform.position + new Vector3(0f,0.6f,0f);
    }
    private void ResetYourHead()
    {
        transform.position = Vector3.Slerp(transform.position,targetPosition,0.01f);
    }
}