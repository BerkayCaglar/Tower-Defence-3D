using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SRAnimationController : MonoBehaviour
{
    [SerializeField]
    private GameObject SRBody;
    [HideInInspector]
    public Animator SRHeadAnimator, SRBodyAnimator;
    private void Start() {
        FindAnimator();
    }
    private void FindAnimator()
    {
        SRHeadAnimator = gameObject.GetComponent<Animator>();
        SRBodyAnimator = SRBody.GetComponent<Animator>();
    }
}
