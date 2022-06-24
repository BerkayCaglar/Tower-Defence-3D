using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{
    [HideInInspector]
    public int lifePoint;
    private void Start() 
    {
        lifePoint = 100;
    }
    private void Update() 
    {
        if(lifePoint < 1) Destroy(gameObject);
    }
}