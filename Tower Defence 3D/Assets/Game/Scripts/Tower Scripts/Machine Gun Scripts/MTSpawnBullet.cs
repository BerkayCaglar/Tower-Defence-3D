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
    private MTBodyMovement mTBodyMovement;
    private bool shotOpen=true;
    private bool Reset;
    void Start()
    {
        FindBarrelObjects();
        InvokeRepeating("SpawnManager",0f,0.1f);
        FindScripts();
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
        if(transform.rotation.y > 0 || transform.rotation.y < 0)
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
        else
        {
            AnimationController(mTAnimationController.bodyAnimator,false,null,mTAnimationController.leftBarrelAnimator,mTAnimationController.rightBarrelAnimator,"all");
            Reset = true;
        }
    }
    private void Update() {
        if(Reset==true)
        {
            mTBodyMovement.ResetBody();
        }
    }
    private void FindBarrelObjects()
    {
        leftBarrel = GameObject.Find("MT-Left Barrel");
        rightBarrel = GameObject.Find("MT-Right Barrel");
    }
    private void FindScripts()
    {
        mTAnimationController = gameObject.GetComponent<MTAnimationController>();
        mTBodyMovement = GameObject.Find("MTBody").GetComponent<MTBodyMovement>();
    }

}   
