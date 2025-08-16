using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinbehaviourscript : MonoBehaviour
{
    public AudioClip css;

    void OnTriggerEnter2D(Collider2D other) {
        AudioSource.PlayClipAtPoint(css, transform.position);
        Destroy(this.gameObject);
    }
}