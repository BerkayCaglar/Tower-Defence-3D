using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MTAmmoMovement : MonoBehaviour
{
    private float speed = 40f;
    private bool go = true;

    private void Update() {
        if(go)
        {
            gameObject.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        
    }
    private void OnCollisionEnter() {
        go=false;
    }
}
