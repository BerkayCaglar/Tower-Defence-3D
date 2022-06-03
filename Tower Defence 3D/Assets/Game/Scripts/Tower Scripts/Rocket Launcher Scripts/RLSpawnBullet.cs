using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RLSpawnBullet : TowerManager
{
    [SerializeField]
    private GameObject rocketBullet;
    private RLAnimationController rLAnimationController;
    private RLBodyMovement rLBodyMovement;
    private bool Reset;
    private void Start() {
        InvokeRepeating("SpawnRocketBullet",0f,1f);   
        FindScripts(); 
    }
    private void SpawnRocketBullet()
    {
        if(transform.rotation.y > 0 || transform.rotation.y < 0)
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
        rLAnimationController = GameObject.Find("RLHead").GetComponent<RLAnimationController>();
        rLBodyMovement = GameObject.Find("RLBody").GetComponent<RLBodyMovement>();
    }
}
