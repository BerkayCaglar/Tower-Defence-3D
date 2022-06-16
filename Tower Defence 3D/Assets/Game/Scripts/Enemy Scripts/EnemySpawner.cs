using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Enemies;
    [HideInInspector]
    public float enemiesSpawned { get; private set; }
    void Start()
    {
        InvokeRepeating("Spawner",0f,1f);
    }
    private void Spawner()
    {
        if(enemiesSpawned <= 15)
        {
            Instantiate(Enemies[0],transform.position,Enemies[0].transform.rotation);
            enemiesSpawned ++;
        }
        else
        {
            CancelInvoke("Spawner");
        }   
    }
}