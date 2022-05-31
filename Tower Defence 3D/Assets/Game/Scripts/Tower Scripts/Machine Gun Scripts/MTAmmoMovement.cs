using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MTAmmoMovement : TowerManager
{
    private float Speed = 40f;
    private bool Continue = true;

    private void Update() {
        if(Continue)
        {
            MoveForward();
            
            transform.rotation=LookTarget(); // TowerManager.cs
        }
    }
    private void OnCollisionEnter() {
        if(Continue)
            gameObject.GetComponentInChildren<ParticleSystem>().gameObject.SetActive(false);
        Continue=false;   
    }
    private void MoveForward()
    {
        gameObject.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
    }
}
