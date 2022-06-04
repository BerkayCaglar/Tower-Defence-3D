using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MTAnimationController : MonoBehaviour
{
    [SerializeField]
    private GameObject leftBarrel, rightBarrel, Body;
    [HideInInspector]
    public Animator leftBarrelAnimator, rightBarrelAnimator, bodyAnimator;
    
    private void Start() {
        FindBarrelAnimators();
    }
    private void FindBarrelAnimators()
    {
        leftBarrelAnimator = leftBarrel.GetComponent<Animator>();
        rightBarrelAnimator = rightBarrel.GetComponent<Animator>();
        bodyAnimator = Body.GetComponent<Animator>();
    }
}
