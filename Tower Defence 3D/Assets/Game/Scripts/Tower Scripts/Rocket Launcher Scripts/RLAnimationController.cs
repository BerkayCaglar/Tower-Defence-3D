using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RLAnimationController : MonoBehaviour
{
    private Animator Animator;
    private GameObject rocketLauncherBody;
    private void Start() {
        FindAnimator();
        rocketLauncherBody = GameObject.Find("RLBody");
    }
    public void PlayRLAnimation()
    {
        Animator.SetBool("IsAttacking",true);    
    }
    public void ResetBarrelPosition()
    {
        
    }
    public void StopRLAnimation()
    {
        Animator.SetBool("IsAttacking",false);
    }
    private void FindAnimator()
    {
        Animator = gameObject.GetComponent<Animator>();
    }
}
