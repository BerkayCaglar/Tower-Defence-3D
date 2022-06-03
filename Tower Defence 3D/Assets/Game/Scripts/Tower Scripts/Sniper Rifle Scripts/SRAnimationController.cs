using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SRAnimationController : MonoBehaviour
{
    public Animator SRHeadAnimator;
    public Animator SRBodyAnimator;
    private void Start() {
        FindAnimator();
    }
    private void FindAnimator()
    {
        SRHeadAnimator = gameObject.GetComponent<Animator>();
        SRBodyAnimator = GameObject.Find("SR Body").GetComponent<Animator>();
    }
}
