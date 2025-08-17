using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindZoneEins : MonoBehaviour
{
    public float Höhe;

    public Vector2 v = new Vector2(0,1);

    void OnTriggerStay2D(Collider2D other){
        other.gameObject.GetComponent<Rigidbody2D>().AddForce(v*Höhe,ForceMode2D.Impulse);
    }

}
