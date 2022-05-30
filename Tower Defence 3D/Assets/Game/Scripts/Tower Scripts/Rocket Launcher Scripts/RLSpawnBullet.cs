using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RLSpawnBullet : MonoBehaviour
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
        rLAnimationController.ResetBarrelPosition();
        Instantiate(rocketBullet,transform.position,transform.rotation);
        rLAnimationController.PlayRLAnimation();
    }
    private void FindRLAnimationController()
    {
        rLAnimationController = GameObject.Find("RLHead").GetComponent<RLAnimationController>();
    }
}
