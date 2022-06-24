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
        if(enemiesSpawned < 50)
        {
            int randomEnemy = Random.Range(0,1);
            Debug.Log(randomEnemy);
            Instantiate(Enemies[randomEnemy],transform.position,Enemies[randomEnemy].transform.rotation);
            enemiesSpawned ++;
        }
        else
        {
            CancelInvoke("Spawner");
        }   
    }
}