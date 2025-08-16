using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindZone : MonoBehaviour
{
    public float Höhe;
    void OnTriggerEnter2D(Collider2D other){
        other.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up*Höhe,ForceMode2D.Impulse);
    }
}
