using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MTSpawnBullet : TowerManager
{
    [SerializeField]
    private GameObject bullet;
    private GameObject leftBarrel;
    private GameObject rightBarrel;
    private MTAnimationController mTAnimationController;
    private bool shotOpen=true;
    void Start()
    {
        FindBarrelObjects();
        InvokeRepeating("SpawnManager",0f,0.1f);
        FindMTAnimationController();
    }
    private void SpawnLeftBullet()
    {
        Instantiate(bullet,leftBarrel.transform.position,gameObject.transform.rotation);
        shotOpen = false;
    }
    private void SpawnRightBullet()
    {
        Instantiate(bullet,rightBarrel.transform.position,gameObject.transform.rotation);
        shotOpen = true;
    }
    
    private void SpawnManager()
    {
        if (shotOpen)
        {
            SpawnLeftBullet();
            AnimationController(mTAnimationController.bodyAnimator,true,null,mTAnimationController.leftBarrelAnimator,mTAnimationController.rightBarrelAnimator,"left");
        }
        else
        {
            SpawnRightBullet();
            AnimationController(mTAnimationController.bodyAnimator,true,null,mTAnimationController.leftBarrelAnimator,mTAnimationController.rightBarrelAnimator,"right");
        }
    }
    private void FindBarrelObjects()
    {
        leftBarrel = GameObject.Find("MT-Left Barrel");
        rightBarrel = GameObject.Find("MT-Right Barrel");
    }
    private void FindMTAnimationController()
    {
        mTAnimationController = gameObject.GetComponent<MTAnimationController>();
    }

}   
