using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SRAnimationController : MonoBehaviour
{
    private Animator SRHeadAnimator;
    private Animator SRBodyAnimator;
    private void Start() {
        FindAnimator();
    }
    public void PlaySRAnimation()
    {
        SRHeadAnimator.SetBool("IsAttacking",true);    
        SRBodyAnimator.SetBool("IsAttacking",true);
    }
    public void StopSRAnimation()
    {
        SRHeadAnimator.SetBool("IsAttacking",false);
        SRBodyAnimator.SetBool("IsAttacking",false);
    }
    private void FindAnimator()
    {
        SRHeadAnimator = gameObject.GetComponent<Animator>();
        SRBodyAnimator = GameObject.Find("SR Body").GetComponent<Animator>();
    }
}
