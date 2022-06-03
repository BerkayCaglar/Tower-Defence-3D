using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RLAnimationController : MonoBehaviour
{
    public Animator RLHeadAnimator;
    public Animator RLBodyAnimator;
    private void Start() {
        FindAnimator();
    }
    private void FindAnimator()
    {
        RLHeadAnimator = gameObject.GetComponent<Animator>();
        RLBodyAnimator = GameObject.Find("RLBody").GetComponent<Animator>();
    }
}
