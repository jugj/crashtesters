using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearDrag : MonoBehaviour
{
  public Rigidbody2D rb;
    public float normalDrag = 0f;
    public float highDrag = 5f;

    void Start()
    {
        if (rb == null)
            rb = GetComponent<Rigidbody2D>();

        rb.drag = normalDrag;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.drag = highDrag;
        }
        else
        {
            rb.drag = normalDrag;
        }
    }
}

