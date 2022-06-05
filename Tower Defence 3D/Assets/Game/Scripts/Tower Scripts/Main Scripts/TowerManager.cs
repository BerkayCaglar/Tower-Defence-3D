using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerManager : MonoBehaviour
{
    private GameObject Target;
    private float followSpeed = 20f;
    private float turretDistance;
    private void Awake() 
    {
        //FindTargetObject();
        InvokeRepeating("FindTargets",0f,0.5f);
    }
    public Quaternion LookTarget(float TurretDistance,MTSpawnBullet mTSpawnBullet=null,RLSpawnBullet rLSpawnBullet=null,SRSpawnBullet sRSpawnBullet=null)
    {
        if(Target !=null)
        {
            if(Vector3.Distance(Target.transform.position, transform.position) > TurretDistance)
            {
                turretDistance = TurretDistance;
                SetScriptVariables(mTSpawnBullet,rLSpawnBullet,sRSpawnBullet,false);
                return Quaternion.Slerp(transform.rotation,new Quaternion(0f,0f,0f,1f),Time.deltaTime*2f);
            }
            else
            {
                turretDistance = TurretDistance;
                SetScriptVariables(mTSpawnBullet,rLSpawnBullet,sRSpawnBullet,true);
                Quaternion lookDirection = Quaternion.LookRotation(Target.transform.position - transform.position);
                return Quaternion.Slerp(transform.rotation,lookDirection,Time.deltaTime * followSpeed);
            }
        }
        else
        {
            turretDistance = TurretDistance;
            SetScriptVariables(mTSpawnBullet,rLSpawnBullet,sRSpawnBullet,false);
            return Quaternion.Slerp(transform.rotation,new Quaternion(0f,0f,0f,1f),Time.deltaTime*2f);
        }
    }
    public Quaternion LookTargetSlow(float TurretDistance)
    {
        Debug.Log(Target);
        if(Target !=null)
        {
            
            if(Vector3.Distance(Target.transform.position, transform.position) > TurretDistance)
            {
                return Quaternion.Slerp(transform.rotation,new Quaternion(0f,0f,0f,1f),Time.deltaTime);
            }
            else
            {
                Quaternion Follow = Quaternion.LookRotation(Target.transform.position - gameObject.transform.position);
                return Quaternion.Slerp(transform.rotation,Follow,Time.deltaTime);
            }
        }
        else
        {
            return Quaternion.Slerp(transform.rotation,new Quaternion(0f,0f,0f,1f),Time.deltaTime*2f);
        }
        
    }
    /*
    public bool ReturnFiringVariable()
    {
        return Firing ?  true :  false;
    }
    */
    public void FindTargets()
    {
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;
        GameObject [] Enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in Enemies)
        {
            float distanceToEnemy = Vector3.Distance(Enemy.transform.position, transform.position);
            if(distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = Enemy;
            }
        }
        if(nearestEnemy !=null & shortestDistance <= turretDistance)
        {
            Target=nearestEnemy;
        }
        else
        {
            Target=null;
        }
    }
    private void SetScriptVariables(MTSpawnBullet mTSpawnBullet,RLSpawnBullet rLSpawnBullet,SRSpawnBullet sRSpawnBullet,bool set)
    {
        if(mTSpawnBullet !=null)
        {
            mTSpawnBullet.Firing = set;
        }
        if(rLSpawnBullet !=null)
        {
            rLSpawnBullet.Firing = set;
        }
        if(sRSpawnBullet !=null)
        {
            sRSpawnBullet.Firing = set;
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