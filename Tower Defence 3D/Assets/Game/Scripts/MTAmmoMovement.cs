using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MTAmmoMovement : MonoBehaviour
{
    private float speed = 10f;

    private void Update() {
        gameObject.transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
