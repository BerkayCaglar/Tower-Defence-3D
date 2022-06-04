using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MTBarrelMovement : MonoBehaviour
{
    [SerializeField]
    private GameObject MTBody;
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
        targetPosition = MTBody.transform.position;
    }
    private void ResetYourHead()
    {
        transform.position = Vector3.Slerp(transform.position,targetPosition,0.01f);
    }
}
