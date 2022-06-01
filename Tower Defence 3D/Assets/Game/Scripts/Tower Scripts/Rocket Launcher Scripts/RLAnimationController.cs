using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RLAnimationController : MonoBehaviour
{
    private Animator RLHeadAnimator;
    private Animator RLBodyAnimator;
    private void Start() {
        FindAnimator();
    }
    public void PlayRLAnimation()
    {
        RLHeadAnimator.SetBool("IsAttacking",true);    
        RLBodyAnimator.SetBool("IsAttacking",true);
    }
    public void StopRLAnimation()
    {
        RLHeadAnimator.SetBool("IsAttacking",false);
        RLBodyAnimator.SetBool("IsAttacking",false);
    }
    private void FindAnimator()
    {
        RLHeadAnimator = gameObject.GetComponent<Animator>();
        RLBodyAnimator = GameObject.Find("RLBody").GetComponent<Animator>();
    }
}
