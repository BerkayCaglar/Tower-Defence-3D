using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MTSpawnBullet : TowerManager
{
    [SerializeField]
    private GameObject bullet, leftBarrel, rightBarrel, MTBody;
    private MTAnimationController mTAnimationController;
    private MTBodyMovement mTBodyMovement;
    private bool shotOpen=true, Reset;
    public bool Firing;
    void Start()
    {
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
        if(Firing)
        {
            if (shotOpen)
            {
                SpawnLeftBullet();
                AnimationController(mTAnimationController.bodyAnimator,true,null,mTAnimationController.leftBarrelAnimator,mTAnimationController.rightBarrelAnimator,"left"); // TowerManager.cs
            }
            else
            {
                SpawnRightBullet();
                AnimationController(mTAnimationController.bodyAnimator,true,null,mTAnimationController.leftBarrelAnimator,mTAnimationController.rightBarrelAnimator,"right"); // TowerManager.cs
            }
        }
        else
        {
            AnimationController(mTAnimationController.bodyAnimator,false,null,mTAnimationController.leftBarrelAnimator,mTAnimationController.rightBarrelAnimator,"all"); // TowerManager.cs
            Reset = true;
        }
    }
    private void Update() {
        if(Reset==true)
        {
            mTBodyMovement.ResetBody();
        }
    }
    private void FindScripts()
    {
        mTAnimationController = gameObject.GetComponent<MTAnimationController>();
        mTBodyMovement = MTBody.GetComponent<MTBodyMovement>();
    }
}   
