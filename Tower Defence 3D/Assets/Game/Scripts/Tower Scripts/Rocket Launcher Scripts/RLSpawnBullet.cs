using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RLSpawnBullet : TowerManager
{
    [SerializeField]
    private GameObject rocketBullet, RLHead, RLBody;
    private RLAnimationController rLAnimationController;
    private RLBodyMovement rLBodyMovement;
    private bool Reset;
    public bool Firing;
    private void Start() {
        InvokeRepeating("SpawnRocketBullet",0f,1f);   
        FindScripts(); 
    }
    private void SpawnRocketBullet()
    {
        if(Firing)
        {
            Instantiate(rocketBullet,transform.position,transform.rotation);
            AnimationController(rLAnimationController.RLBodyAnimator,true,rLAnimationController.RLHeadAnimator);
        }
        else
        {
            AnimationController(rLAnimationController.RLBodyAnimator,false,rLAnimationController.RLHeadAnimator);
            Reset=true;
        }
    }
    private void Update() {
        if(Reset==true)
        {
            rLBodyMovement.ResetBody();
        }
    }
    private void FindScripts()
    {
        rLAnimationController = RLHead.GetComponent<RLAnimationController>();
        rLBodyMovement = RLBody.GetComponent<RLBodyMovement>();
    }
}
