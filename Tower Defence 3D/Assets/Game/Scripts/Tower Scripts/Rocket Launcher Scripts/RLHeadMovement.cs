using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RLHeadMovement : MonoBehaviour
{
    [SerializeField]
    private GameObject RLBody;
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
        targetPosition = RLBody.transform.position + new Vector3(0f,0.5f,0f);
    }
    private void ResetYourHead()
    {
        transform.position = Vector3.Slerp(transform.position,targetPosition,0.01f);
    }
}