using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MTAnimationController : MonoBehaviour
{
    private Animator leftBarrelAnimator;
    private Animator rightBarrelAnimator;
    private Animator bodyAnimator;
    private MTSpawnBullet mTSpawnBullet;
    
    private void Start() {
        FindBarrelAnimators();
        FindMTSpawnBullet();
    }
    public void PlayRightBarrelAnimation()
    {
        rightBarrelAnimator.SetBool("IsAttacking",true);
        //rightBarrelAnimator.SetFloat("AnimationSpeed",mTSpawnBullet.ammoSpawnRate+1f);
    }
    public void PlayLeftBarrelAnimation()
    {
        leftBarrelAnimator.SetBool("IsAttacking",true);
        //leftBarrelAnimator.SetFloat("AnimationSpeed",mTSpawnBullet.ammoSpawnRate+1f);
    }
    public void StopBarrelAnimation()
    {
        rightBarrelAnimator.SetBool("IsAttacking",false);
        leftBarrelAnimator.SetBool("IsAttacking",false);
    }
    public void PlayBodyShakeAnimation()
    {
        bodyAnimator.SetBool("IsAttacking",true);
    }
    public void StopBodyShakeAnimation()
    {
        bodyAnimator.SetBool("IsAttacking",false);
    }
    private void FindMTSpawnBullet()
    {
        mTSpawnBullet = gameObject.GetComponent<MTSpawnBullet>();
    }
    private void FindBarrelAnimators()
    {
        leftBarrelAnimator = GameObject.Find("MT-Left Barrel").GetComponent<Animator>();
        rightBarrelAnimator = GameObject.Find("MT-Right Barrel").GetComponent<Animator>();
        bodyAnimator = GameObject.Find("MTBody").GetComponent<Animator>();
    }
}
