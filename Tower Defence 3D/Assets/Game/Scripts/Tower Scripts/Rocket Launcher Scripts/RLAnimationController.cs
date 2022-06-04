using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RLAnimationController : MonoBehaviour
{
    [SerializeField]
    private GameObject RLBody, RLHead;
    [HideInInspector]
    public Animator RLHeadAnimator, RLBodyAnimator;
    private void Start() {
        FindAnimator();
    }
    private void FindAnimator()
    {
        RLHeadAnimator = RLHead.GetComponent<Animator>();
        RLBodyAnimator = RLBody.GetComponent<Animator>();
    }
}
