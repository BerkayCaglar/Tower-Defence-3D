using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerManager : MonoBehaviour
{
    private GameObject Target;
    private float followSpeed = 20f;
    private void Start() 
    {
        FindTargetObject();
    }
    public Quaternion LookTarget(float TurretDistance)
    {
        if(Vector3.Distance(Target.transform.position, transform.position) > TurretDistance)
        {
            return new Quaternion(0f,0f,0f,0f);
        }
        else
        {
            Quaternion lookDirection = Quaternion.LookRotation(Target.transform.position - transform.position);
            return Quaternion.Slerp(transform.rotation,lookDirection,Time.deltaTime * followSpeed);
        }
    }
    public Quaternion LookTargetSlow(float TurretDistance)
    {
        if(Vector3.Distance(Target.transform.position, transform.position) > TurretDistance)
        {
            return new Quaternion(0f,0f,0f,0f);
        }
        else
        {
            Quaternion Follow = Quaternion.LookRotation(Target.transform.position - gameObject.transform.position);
            return Quaternion.Slerp(transform.rotation,Follow,Time.deltaTime);
        }
    }
    public void RemoveTheBullet
    (GameObject bulletGameObject,ParticleSystem Expolsion)
    {
        Expolsion.transform.parent = null;
        Expolsion.transform.localScale = new Vector3(0.5f,0.5f,0.5f);
        Expolsion.Play();
        Destroy(gameObject);
        Destroy(Expolsion.gameObject,0.5f);
    }
    public void AnimationController(Animator BodyAnimator,bool DoYouWantToPlay,Animator HeadAnimator=null,Animator MTLeftBarrelAnimator = null,Animator MTRightBarrelAnimator = null,string LeftOrRight=null)
    {
        if(HeadAnimator !=null)
        {
            HeadAnimator.SetBool("IsAttacking",DoYouWantToPlay);
            BodyAnimator.SetBool("IsAttacking",DoYouWantToPlay);
        }
        
        if(MTLeftBarrelAnimator != null && MTRightBarrelAnimator != null && LeftOrRight != null)
        {
            BodyAnimator.SetBool("IsAttacking",DoYouWantToPlay);
            if(LeftOrRight == "left")
            {
                MTRightBarrelAnimator.SetBool("IsAttacking",DoYouWantToPlay);
            }
            else if(LeftOrRight == "all")
            {
                MTRightBarrelAnimator.SetBool("IsAttacking",DoYouWantToPlay);
                MTLeftBarrelAnimator.SetBool("IsAttacking",DoYouWantToPlay);
                BodyAnimator.SetBool("IsAttacking",DoYouWantToPlay);
            }
            else
            {
                MTLeftBarrelAnimator.SetBool("IsAttacking",DoYouWantToPlay);
            }
        }
    }
    private void FindTargetObject()
    {
       Target = GameObject.Find("Target Cube");
    }
    public Vector3 ResetYourBody(GameObject Body,Vector3 StartPosition)
    {
        return Vector3.Slerp(Body.transform.position,StartPosition,Time.deltaTime);
    }
}