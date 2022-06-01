using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SRHeadMovement : MonoBehaviour
{
    private GameObject SRBody;
    private Vector3 targetPosition;
    private void Start() 
    {
        FindSRBody();
        SetTargetPosition();
    }
    private void Update() 
    {
       ResetYourHead();
    }
    private void FindSRBody()
    {
        SRBody = GameObject.Find("SR Body");
    }
    private void SetTargetPosition()
    {
        targetPosition = SRBody.transform.position + new Vector3(0f,0.5f,0f);
    }
    private void ResetYourHead()
    {
        transform.position = Vector3.Slerp(transform.position,targetPosition,0.01f);
    }
}
