using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SRSpawnBullet : TowerManager
{
    [SerializeField]
    private GameObject SRBullet;
    private SRAnimationController sRAnimationController;
    private void Start() {
        InvokeRepeating("SpawnSRBullet",0f,2f);   
        FindSRAnimationController(); 
    }
    private void SpawnSRBullet()
    {
        Instantiate(SRBullet,transform.position,transform.rotation);
        AnimationController(sRAnimationController.SRBodyAnimator,true,sRAnimationController.SRHeadAnimator);
    }
    private void FindSRAnimationController()
    {
        sRAnimationController = GameObject.Find("SR Head").GetComponent<SRAnimationController>();
    }
}
