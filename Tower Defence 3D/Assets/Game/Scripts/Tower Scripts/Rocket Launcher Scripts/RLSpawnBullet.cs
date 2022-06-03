using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RLSpawnBullet : TowerManager
{
    [SerializeField]
    private GameObject rocketBullet;
    private RLAnimationController rLAnimationController;
    private void Start() {
        InvokeRepeating("SpawnRocketBullet",0f,1f);   
        FindRLAnimationController(); 
    }
    private void SpawnRocketBullet()
    {
        Instantiate(rocketBullet,transform.position,transform.rotation);
        AnimationController(rLAnimationController.RLBodyAnimator,true,rLAnimationController.RLHeadAnimator);
    }
    private void FindRLAnimationController()
    {
        rLAnimationController = GameObject.Find("RLHead").GetComponent<RLAnimationController>();
    }
}
