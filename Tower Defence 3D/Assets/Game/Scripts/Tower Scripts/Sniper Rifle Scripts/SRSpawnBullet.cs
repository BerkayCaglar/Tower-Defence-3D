using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SRSpawnBullet : MonoBehaviour
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
        sRAnimationController.PlaySRAnimation();
    }
    private void FindSRAnimationController()
    {
        sRAnimationController = GameObject.Find("SR Head").GetComponent<SRAnimationController>();
    }
}
