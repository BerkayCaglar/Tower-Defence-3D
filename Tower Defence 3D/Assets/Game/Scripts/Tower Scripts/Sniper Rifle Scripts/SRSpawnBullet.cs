using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SRSpawnBullet : TowerManager
{
    [SerializeField]
    private GameObject SRBullet, SRHead, SRBody;
    private SRBodyMovement sRBodyMovement;
    private SRAnimationController sRAnimationController;
    private bool Reset;
    public bool Firing;
    private void Start() {
        InvokeRepeating("SpawnSRBullet",0f,2f);   
        FindScripts(); 
    }
    private void SpawnSRBullet()
    {
        if(Firing)
        {
            Instantiate(SRBullet,transform.position,transform.rotation);
            AnimationController(sRAnimationController.SRBodyAnimator,true,sRAnimationController.SRHeadAnimator);
        }
        else
        {
            AnimationController(sRAnimationController.SRBodyAnimator,false,sRAnimationController.SRHeadAnimator);
            Reset=true;
        }
    }
    private void Update() {
        if(Reset==true)
        {
            sRBodyMovement.ResetBody();
        }
    }
    private void FindScripts()
    {
        sRAnimationController = SRHead.GetComponent<SRAnimationController>();
        sRBodyMovement = SRBody.GetComponent<SRBodyMovement>();
    }
}
