using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MTAnimationController : MonoBehaviour
{
    public Animator leftBarrelAnimator;
    public Animator rightBarrelAnimator;
    public Animator bodyAnimator;
    
    private void Start() {
        FindBarrelAnimators();
    }
    private void FindBarrelAnimators()
    {
        leftBarrelAnimator = GameObject.Find("MT-Left Barrel").GetComponent<Animator>();
        rightBarrelAnimator = GameObject.Find("MT-Right Barrel").GetComponent<Animator>();
        bodyAnimator = GameObject.Find("MTBody").GetComponent<Animator>();
    }
}
